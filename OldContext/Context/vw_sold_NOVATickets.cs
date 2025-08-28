namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class vw_sold_NOVATickets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vw_sold_NOVATickets()
        {
           
        }

        public string Id { get; set; }
        public int UserID { get; set; }             //User-Id
        public string PersonalNumber { get; set; } //PersonalNummer
        public string LaufNumber { get; set; }      //Laufnummer

        public string CompanyShortName { get; set; }   // "TU"
        public string Region { get; set; }           //Verbund
        public string ValidityRange { get; set; }          //Gueltigkeitsbereich
        public string ProductName { get; set; }         //Produktname
        public int BelegRole { get; set; }              //Beleg Role
        public string ProductDetails { get; set; }      //Produktdetallierung
        public string ArticleNumber { get; set; }       //Artikelnr
        public string BelegId { get; set; }             //BelegID (OfferId from NOVA)
        public int Class1Quantity { get; set; }             //Anz_Kl1_1/1
        public double PriceClass1 { get; set; }              //Einzelpreis_Kl1_1/1
        public int Class2Quantity { get; set; }           //Anz_Kl1_1/2
        public double PriceClass2 { get; set; }         //Einzelpreis_Kl2_1/1
        public int GratisQuantity { get; set; }          //Anz_Gratis
        public int OwnQuantity { get; set; }          //Anz_Eigene
        public string TaxPercentage { get; set; }           //MWSt_Satz
        public double TaxTotal { get; set; }          //MWSt_Total
        public string CurrencyCash { get; set; }              //Währung_Barzahlung
        public double Cash { get; set; }       //Barzahlung
        public double CreditCard { get; set; }          //Kartenzahlung_CHF
        public double OnlinePayment { get; set; }          //OnlinePayment
        public bool Refund { get; set; }             //Storno
        public string RefundReason { get; set; }        //StornoBegruendung
        public decimal CurrencyRate { get; set; }            //Wechselkurs
        public string DeviceImei { get; set; }           //DeviceEmei

        public DateTime CreationDate { get; set; }  //AusstellDatum
        public DateTime UploadedTime { get; set; }
        public DateTime? ModificationDate { get; set; }

        public bool RefundAttempt { get; set; }
        public string QuittungImage { get; set; }

        public bool IsTicketConfirmed { get; set; }

        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public bool SendEmail { get; set; }
        public string Email { get; set; }
        public int MailRetryNumber { get; set; }
        public DateTime? SentMailOK { get; set; }


        public string OnlineTransactionId { get; set; }
        public int printingAttemps { get; set; }

        public string ServiceId { get; set; }

        public string PriceType { get; set; }   //FULL, REDUCED


        [Column(TypeName = "datetime2")]
        public DateTime? Exported { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Deleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Balanced { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CashChecked { get; set; }

        public string ticketDataObject { get; set; }

        public string ticketNOVAXML { get; set; }

        public string refundNOVAXML { get; set; }
        public string refundDataObject { get; set; }

        //public string refundServiceId { get; set; }
        public string ticketLanguage { get; set; }		
        public string vertriebsPunkt { get; set; }
        public string leistungsVermittler { get; set; }

        public string sellPlace { get; set; }
        public string deviceNumber { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public string via1 { get; set; }
        public string via2 { get; set; }
        public string via3 { get; set; }
        public string via4 { get; set; }
        public string paymentMethodString { get; set; }

        public string refundArticleNumber { get; set; }

        public string LeistungsTyp { get; set; }
        public string linkedServiceId { get; set; }


        public static List<vw_sold_NOVATickets> GetByLaufnummer(List<string> laufNummerList)
        {
            using (OpenEyeBackendEntities.Entities context = new Entities())
            {
                IQueryable<vw_sold_NOVATickets> ticketViewTmp = context.vw_sold_NOVAtickets;
                ticketViewTmp = ticketViewTmp.Where(x => laufNummerList.Contains(x.LaufNumber));
                return ticketViewTmp.ToList();
            }
        }

    }
}
