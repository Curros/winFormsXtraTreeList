using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormsXtraTreeList.Models
{
    class TreeListConstants
    {
        public static string PROPERTY_ADD_CHILD = "AddChild";
        public static string PROPERTY_CLEAR_CHILDREN = "ClearChildren";


        /// <summary>
        /// Different node types.
        /// </summary>
        public enum NodeType
        {
            ROOT,
            GROUP,
            LAYER,
            STYLE
        }

    }
}
