﻿using OrderProcessor.BusinessRules.Abstract;
using OrderProcessor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules
{
    public class LearningToSkiRule : BaseProductRule, IProcessOrderRule
    {
        public override void ProcessOrder(Customer customer, List<string> productList)
        {
             
            productList.Add("First Aid Video");

            GeneratePackingSlip(customer, productList);
        }
    }
}
