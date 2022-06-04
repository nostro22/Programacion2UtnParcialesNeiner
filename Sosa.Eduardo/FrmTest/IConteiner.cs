using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmTest
{
    public partial class IConteiner : Component
    {
        public IConteiner()
        {
            InitializeComponent();
        }

        public IConteiner(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
