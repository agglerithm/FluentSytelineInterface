using System.Collections.Generic;
using System.Linq;
using Mongoose.IDO.Protocol;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl.Queries;
using NCommon.Extensions;
using IdoConstants=SytelineInterface.Core.IdoConstants;

namespace SytelineInterface.Factories.impl
{
    public class UpdateCollectionRequestFactory : IUpdateCollectionRequestFactory
    { 
        private static UpdateAction GetUpdateActionFromBuilder(IIdoCommandBuilder builder)
        {
            var action = builder.GetUpdateAction();
            if (action == UpdateAction.None)
                action = UpdateAction.Update;
            return action;
        }
 

        public UpdateCollectionRequestData GetUpdateCollectionRequest( 
            IIdoCommandBuilder builder, LoadCollectionResponseWrapper loadData)
        { 
            var request = new UpdateCollectionRequestData()
                              {
                                  IDOName = builder.GetIDOName(), 
                                  RefreshAfterUpdate = true, 
                                  LinkBy = builder.GetLinkBy()
                              };
            var action = GetUpdateActionFromBuilder(builder);

            request.Items.AddRange(get_update_items(builder, loadData.Records, action));
            return request;
        }

        private IEnumerable<IDOUpdateItem> get_update_items(IIdoCommandBuilder builder, IEnumerable<IdoItemWrapper> list, UpdateAction action)
        {
            var items = new List<IDOUpdateItem>();
            list.ForEach(idoItemWrapper =>
                             {
                                 var item = getUpdateItem(builder, action, idoItemWrapper);
                                 items.Add(item);
                             });
            return items;
        }


        public UpdateCollectionRequestData GetInsertCollectionRequest(IIdoCommandBuilder builder)
        { 
            var request = new UpdateCollectionRequestData()
                              {
                                  IDOName = builder.IdoName, 
                                  RefreshAfterUpdate = true, 
                              }; 
            foreach (IIdoCommandBuilder child in builder.GetChildren())
                child.Action(UpdateAction.Insert);
            request.Items.Add(getInsertItem(builder));
            return request;
        }

        private IDOUpdateItem getInsertItem(IIdoCommandBuilder builder)
        {
            var item = new IDOUpdateItem(UpdateAction.Insert);

            var propertyKeys = builder.Properties.Keys;

            propertyKeys.ForEach(key => item.Properties.Add(key, builder.Properties[key]));

            builder.GetChildren().ForEach(child =>
            {
                item.NestedUpdates.Add(getNestedInsert(child));
            });

            return item;

        }

        private UpdateCollectionDataBase getNestedInsert(IIdoCommandBuilder builder)
        {
            PropertyPair linkBy = null;
            if (builder.GetLinkBy().Length > 0)
                linkBy = builder.GetLinkBy()[0];
            var data = new UpdateCollectionRequestData(builder.GetIDOName());

            var idoUpdateItem = getInsertItem(builder);

            data.Items.Add(idoUpdateItem);

            if (linkBy != null)
                data.SetLinkBy(linkBy.ParentProperty, linkBy.ChildProperty);

            return data;
        }


        private IDOUpdateItem getUpdateItem(IIdoCommandBuilder builder, UpdateAction action, IdoItemWrapper idoItemWrapper)
        {
            var item = new IDOUpdateItem(action);
            item.Action = GetUpdateActionFromBuilder(builder);
            item.ItemID = idoItemWrapper[IdoConstants.KEY].ToString();

            var propertyKeys = builder.Properties.Keys;
            
            propertyKeys.ForEach(key =>  item.Properties.Add(key, builder.Properties[key]));


            builder.GetChildren().ForEach(child =>
                {
                    var updateCollectionRequestData = new List<UpdateCollectionRequestData>();

                    idoItemWrapper.Records.Where(record => record.IdoName == child.IdoName)
                                        .ForEach(record => updateCollectionRequestData.Add(getNestedUpdate(child, record)));

                    updateCollectionRequestData.ForEach(request => item.NestedUpdates.Add(request));
                });

            return item;
        }

        private UpdateCollectionRequestData getNestedUpdate(IIdoCommandBuilder builder, IdoItemWrapper idoItemWrapper)
        {
            PropertyPair linkBy = null;
            if (builder.GetLinkBy().Length > 0)
                linkBy = builder.GetLinkBy()[0];
            var data = new UpdateCollectionRequestData(builder.GetIDOName());

            var idoUpdateItem = getUpdateItem(builder, builder.GetUpdateAction(), idoItemWrapper);
            
            idoUpdateItem.ItemID = idoItemWrapper[IdoConstants.KEY].ToString(); //not needed!!!
            data.Items.Add(idoUpdateItem);
            if (linkBy != null)
                data.SetLinkBy(linkBy.ParentProperty, linkBy.ChildProperty);
            
            return data;
        }
    }
}