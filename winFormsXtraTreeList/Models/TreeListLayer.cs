using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using DevExpress.XtraTreeList;
using static DevExpress.XtraTreeList.TreeList;

namespace winFormsXtraTreeList.Models
{
    /// <summary>
    /// Object to bind in the TreeList
    /// </summary>
    class NodeData : IList<NodeData>, IVirtualTreeListData, INotifyPropertyChanged, IDisposable
    {
        #region [ INotifyPropertyChanged ]

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Fire change in properties event if connected.
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Used to bypass all the changes in properties.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false; //Check if the value is the same, dont fire the event.

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        #region [ NodeData Properties ]

        private int _id;
        private string _name;
        private TreeListConstants.NodeType? _type = null;

        /// <summary>
        /// List of children.
        /// </summary>
        private IList<NodeData> _children = new List<NodeData>();


        public int ID
        {
            get { return _id; }
            set { SetField(ref _id, value); }
        }

        public string Name
        {
            get { return _name; }
            set { SetField(ref _name, value); }
        }

        public TreeListConstants.NodeType? Type
        {
            get { return _type; }
            set { SetField(ref _type, value); }
        }

        #endregion [ NodeData Properties ]

        #region [ Constructor ]

        public NodeData() : this(0,"rootNode", TreeListConstants.NodeType.ROOT) {}

        public NodeData(int _nodeID, string _name, TreeListConstants.NodeType? _nodeType)
        {
            ID = _nodeID;
            Name = _name;
            Type = _nodeType;
        }

        #endregion

        #region [ IList ]
        public int Count
        {
            get
            {
                return _children.Count();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public NodeData this[int index]
        {
            get
            {
                if (Count > 0)
                    return _children[index];
                return null;
            }
            set
            {
                _children[index] = value;
            }
        }

        public NodeData this[string name]
        {
            get
            {
                if (Count > 0)
                    return _children.FirstOrDefault(chld => chld.Name == name);

                return null;
            }
        }

        public int IndexOf(NodeData item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, NodeData item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(NodeData item)
        {
            _children.Add(item);
            OnPropertyChanged( TreeListConstants.PROPERTY_ADD_CHILD );
        }

        public void Add(NodeData item, int Parent)
        {
            _children.First(chld => chld.ID == Parent).Add(item);
            OnPropertyChanged(TreeListConstants.PROPERTY_ADD_CHILD);
        }

        public void Clear()
        {
            _children.Clear();
            OnPropertyChanged(TreeListConstants.PROPERTY_CLEAR_CHILDREN);
        }

        public bool Contains(NodeData item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(NodeData[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(NodeData item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<NodeData> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion [ IList ]

        #region [ IVirtualTreeListData ]

        public void VirtualTreeGetChildNodes(VirtualTreeGetChildNodesInfo info)
        {
            //throw new NotImplementedException();
            info.Children = _children as List<NodeData>;
        }

        public void VirtualTreeGetCellValue(VirtualTreeGetCellValueInfo info)
        {
            //throw new NotImplementedException();
            info.CellData = info.Node.GetType().GetProperty(info.Column.ToString())?.GetValue(info.Node, null);
        }

        public void VirtualTreeSetCellValue(VirtualTreeSetCellValueInfo info)
        {
            var property = this.GetType().GetProperty(info.Column.ToString());
            var val = info.OldCellData;
            try
            {
                val = Convert.ChangeType(info.NewCellData.ToString(), property.PropertyType, CultureInfo.InvariantCulture);
            }
            catch {
                throw;
            }
            finally
            {
                if (val != info.OldCellData)
                {
                    property.SetValue(this, val, null);
                }
            }
        }

        #endregion [ IVirtualTreeListData ]

        #region [ IDisposable ]

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion [ IDisposable ]

    }
}
