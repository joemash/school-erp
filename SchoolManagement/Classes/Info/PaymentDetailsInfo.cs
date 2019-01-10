﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class PaymentDetailsInfo
    {
        #region Variables
        /// <summary>
        /// Private variable declaration part
        /// </summary>
        private decimal _paymentDetailsId;
        private decimal _paymentMasterId;
        private decimal _ledgerId;
        private decimal _amount;
        private decimal _exchangeRateId;
        private string _chequeNo;
        private DateTime _chequeDate;
        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;
        #endregion
        #region properties
        /// <summary>
        /// Property to get and set PaymentDetailsId
        /// </summary>
        public decimal PaymentDetailsId
        {
            get { return _paymentDetailsId; }
            set { _paymentDetailsId = value; }
        }
        /// <summary>
        /// Property to get and set PaymentMasterId
        /// </summary>
        public decimal PaymentMasterId
        {
            get { return _paymentMasterId; }
            set { _paymentMasterId = value; }
        }
        /// <summary>
        /// Property to get and set LedgerId
        /// </summary>  
        public decimal LedgerId
        {
            get { return _ledgerId; }
            set { _ledgerId = value; }
        }
        /// <summary>
        /// Property to get and set Amount
        /// </summary>
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        /// <summary>
        /// Property to get and set ExchangeRateId
        /// </summary>
        public decimal ExchangeRateId
        {
            get { return _exchangeRateId; }
            set { _exchangeRateId = value; }
        }
        /// <summary>
        /// Property to get and set ChequeNo
        /// </summary>
        public string ChequeNo
        {
            get { return _chequeNo; }
            set { _chequeNo = value; }
        }
        /// <summary>
        /// Property to get and set ChequeDate
        /// </summary>
        public DateTime ChequeDate
        {
            get { return _chequeDate; }
            set { _chequeDate = value; }
        }
        /// <summary>
        /// Property to get and set ExtraDate
        /// </summary> 
        public DateTime ExtraDate
        {
            get { return _extraDate; }
            set { _extraDate = value; }
        }
        /// <summary>
        /// Property to get and set Extra1
        /// </summary>  
        public string Extra1
        {
            get { return _extra1; }
            set { _extra1 = value; }
        }
        /// <summary>
        /// Property to get and set Extra2
        /// </summary>  
        public string Extra2
        {
            get { return _extra2; }
            set { _extra2 = value; }
        }
        #endregion
    }
}
