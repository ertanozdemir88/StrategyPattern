using StrategyPattern;

Payment payment = new Payment(new CreditCardPayment());
payment.ProcessPayment(2000);

