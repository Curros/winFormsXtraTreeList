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
        /// Notifica el cambio de propiedades
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        public int ID { get; set; }

        public string Name { get; set; }
        
        public NodeType? Type { get; set; } = null;

        /// <summary>
        /// List of children.
        /// </summary>
        private IList<NodeData> _children = new List<NodeData>();

        #region [ Constructor ]

        public NodeData() : this(0,"rootNode", NodeType.ROOT) {}

        public NodeData(int _nodeID, string _name, NodeType? _nodeType)
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
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
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
        }

        public void Add(NodeData item, int Parent)
        {
            _children.First(chld => chld.ID == Parent).Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
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
                    NotifyPropertyChanged(info.NewCellData.ToString());
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



    /// <summary>
    /// Different node types.
    /// </summary>
    enum NodeType
    {
        ROOT,
        GROUP,
        LAYER,
        STYLE
    }

}
