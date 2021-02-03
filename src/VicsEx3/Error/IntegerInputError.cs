namespace VicsEx3
{
    public class IntegerInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a decimal number in an integer only field. This fired an error!";
        }
    }
}