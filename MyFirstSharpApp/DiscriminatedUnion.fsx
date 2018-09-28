type CheckNumber = int
type CardNumber = string
type CardType = Visa | Mastercard
type CreditcardInfo = CardNumber * CardType

type PaymentMethod = 
    | Cash
    | Check of CheckNumber
    | Card of CreditcardInfo


type PaymentAmount = decimal
type Currency = Euro | USD

type Payment = {
    Amount : PaymentAmount
    Currency : Currency
    Method : PaymentMethod
}

let a:PaymentAmount = decimal(10)
let p ={ Amount=decimal(10); Currency=Euro;Method=Cash}