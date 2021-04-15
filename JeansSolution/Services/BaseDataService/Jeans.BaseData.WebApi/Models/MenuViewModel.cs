using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeans.BaseData.WebApi.Models
{
    public class MenuViewModel
    {
        private List<MenuViewModel> _menuViewModels;

        public List<MenuViewModel> MenuViewModels
        {
            get
            {
                return _menuViewModels ??= new List<MenuViewModel>();
            }
            set
            {
                _menuViewModels = value;
            }
        }

        public Guid Id { get; set; }

        public Guid ParentId { get; set; }

        public string MenuName { get; set; }

        public string AreaName { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public string IconClass { get; set; }

        public int Sort { get; set; }
    }
}
