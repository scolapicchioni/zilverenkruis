﻿using Microsoft.EntityFrameworkCore;
using op30.ConsoleApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace op30.ConsoleApplication.Data {
    public class ApplicationContext : DbContext{
        public DbSet<Product> Products { get; set; }

        
    }
}
