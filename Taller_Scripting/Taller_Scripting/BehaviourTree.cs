using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Scripting
{
    internal class BehaviourTree
    {
        private NodoRaiz root;

        public BehaviourTree(NodoRaiz rootNode)
        {
            root = rootNode ?? throw new ArgumentNullException(nameof(rootNode));
        }

        public bool Ejecutar()
        {
            return root.Ejecutar();
        }
    }
}

