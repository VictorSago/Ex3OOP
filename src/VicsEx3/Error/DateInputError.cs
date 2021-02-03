namespace VicsEx3
{
    public class DateInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text or number input in a date only field. This fired an error!";
        }
    }
}