/* Copyright (c) 2021 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using AndroidX.RecyclerView.Widget; ??? need to find whot it needs? adapter?

namespace Tizen.NUI.Components
{
    internal static class ItemsSourceFactory
    {
        public static IItemSource Create(IEnumerable itemsSource, ICollectionChangedNotifier notifier)
        {
            if (itemsSource == null)
            {
                return new EmptySource();
            }

            switch (itemsSource)
            {
                case IList list when itemsSource is INotifyCollectionChanged:
                    return new ObservableItemSource(new MarshalingObservableCollection(list), notifier);
                case IEnumerable _ when itemsSource is INotifyCollectionChanged:
                    return new ObservableItemSource(itemsSource, notifier);
                case IEnumerable<object> generic:
                    return new ListSource(generic);
            }

            return new ListSource(itemsSource);
        }

        public static IItemSource Create(RecyclerView recyclerView)
        {
            return Create(recyclerView.ItemsSource, recyclerView);
        }

        public static IGroupableItemSource Create(CollectionView colView)
        {
            var source = colView.ItemsSource;

            if (colView.IsGrouped && source != null)
                return new ObservableGroupedSource(colView, colView);

            else
                return new UngroupedItemSource(Create(colView.ItemsSource, colView));
        }
    }
}
