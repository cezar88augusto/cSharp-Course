using Interface.Entities;
using System;


namespace Interface.Services
{
    class RentalService
    {

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
                
        private ITaxService _taxService;

        //Esta classe depende de um serviço de ITaxSerice

        //Inversão de controle por injeção de dependência: INFORMAR O OBJETO POR MEIO DO CONSTRUTOR! 

       //A classe Rental Service, não instância a dependencia dela (criar um objeto da classe ITaxService nesta classe). Apenas recebe um objeto do tipo ITaxService e passa ele no construtor.
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }

            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
