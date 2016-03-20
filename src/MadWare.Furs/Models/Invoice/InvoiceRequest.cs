﻿using MadWare.Furs.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MadWare.Furs.Models.Invoice
{
    public class InvoiceRequest
    {
        [XmlAttribute()]
        public string Id = "data";

        /// <summary>
        /// Glava sporočila / Message header
        /// </summary>
        public Header Header { get; set; }

        /// <summary>
        /// Račun / Invoice
        /// </summary>
        public Invoice Invoice { get; set; }

        /// <summary>
        /// Račun iz vezane knjige / Sales book invoice
        /// </summary>
        public SalesBookInvoice SalesBookInvoice { get; set; }

        public bool ShouldSerializeInvoice()
        {
            return this.Invoice != null;
        }

        public bool ShouldSerializeSalesBookInvoice()
        {
            return this.SalesBookInvoice != null;
        }
    }
}