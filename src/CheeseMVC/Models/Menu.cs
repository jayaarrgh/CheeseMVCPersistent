﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // NOTICE: Not a list of cheeses, but of relationship(s), i.e. CheeseMenu(s).
        public IList<CheeseMenu> CheeseMenus { get; set; } = new List<CheeseMenu>() ;
    }
}