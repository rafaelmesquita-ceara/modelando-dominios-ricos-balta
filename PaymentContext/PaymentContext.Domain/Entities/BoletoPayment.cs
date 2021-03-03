using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
  public class BoletoPayment : Payment
  {
    public BoletoPayment(
      string boletoNumber,
      string barCode,
      DateTime paidDate,
      DateTime expireDate,
      decimal total,
      decimal totalPaid,
      Document document,
      string payer,
      Address address,
      Email email
      ) : 
      base(
        paidDate, 
        expireDate, 
        total, 
        totalPaid, 
        document, 
        payer, 
        address, 
        email
      )
    {
      BoletoNumber = boletoNumber;
      BarCode = barCode;
    }

    public string BoletoNumber { get; private set; }
    public string BarCode { get; private set; }
  }
}