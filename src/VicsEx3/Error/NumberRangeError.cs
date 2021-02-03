namespace VicsEx3
{
    public class NumberRangeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to input a number that is too low or too high. This fired an error!";
        }
    }
}