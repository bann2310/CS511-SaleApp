﻿using _1015bookstore.viewmodel.Catalog.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.application.Helper
{
    public interface IEmailSender
    {
        public Task SendEmailForgotPassword(string emailTo, string code);
        Task SendEmailAfterBuy(string emailTo, OrderViewModel order);


    }
}
