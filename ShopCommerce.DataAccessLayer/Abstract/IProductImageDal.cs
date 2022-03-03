﻿using ShopCommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCommerce.DataAccessLayer.Abstract
{
    public interface IProductImageDal : IRepositoryDal<ProductImage>
    {
        //void AddRange(List<ProductImage> images);
    }
}
