﻿using System;
using ScnDiscounts.Control;
using ScnDiscounts.Control.Pages;
using ScnDiscounts.DependencyInterface;
using ScnDiscounts.Views.ContentUI;
using Xamarin.Forms;

namespace ScnDiscounts.ViewModels
{
    class AboutViewModel : BaseViewModel
    {
        private AboutContentUI contentUI
        {
            get { return (AboutContentUI)ContentUI; }
        }

        public void txtLink_Click(object sender, EventArgs e)
        {
            LabelExtended label = sender as LabelExtended;
            if (!String.IsNullOrWhiteSpace(label.Text))
                Device.OpenUri(new Uri(label.Text));
        }

        /*public void OnPhoneViewItemTapped(object sender, ItemTappedEventArgs e)
        {
        }*/


        public void txtPhone_Click(object sender, EventArgs e)
        {
            LabelExtended label = sender as LabelExtended;
            string phoneNumber = label.Text.ToLower();
            phoneNumber = phoneNumber.Replace(":", "").Replace("phone", "").Replace("-", "").Trim();
            if (!String.IsNullOrWhiteSpace(phoneNumber))
                DependencyService.Get<IPhoneService>().DialNumber(phoneNumber, "ScienceSoft");
        }
    }
}
