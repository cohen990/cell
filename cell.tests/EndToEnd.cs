namespace cell.tests
{
    public class EndToEnd
    {
        // Typical end to end flow
        /*
         * user enters input e.g. their name
         * the input cell accepts the input
         * broadcasts an "input received hormone" on the endocrine system
         * various cells respond to this hormone
         * e.g. input validation
         * e.g. storage cell
         * 
         * input validation cell will recieve the input
         * will validate the input using internal organelles
         * will broadcast an "input validated hormone"
         * 
         * raw input logger will receive input received hormone
         * will log some stuff about the raw input
         * 
         * storage cell will receive input validated hormone
         * will store the validated input
         * will emit an "input stored hormone"
         * 
         */
    }
}
