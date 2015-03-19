using System.Data.Entity;

namespace SmartHouse
{

    public class SmartHouseBLL
    {
        string SQLConnection = @"Data Source=smarthouse.ctxqmmzfu2jc.us-west-2.rds.amazonaws.com,1433;
                                Initial Catalog=SmartHouse;User ID=SmartHouse;Password=SmartHouse";
        protected DbContext context { get; set; }
        public SmartHouseBLL()
        {
            context = new DbContext(SQLConnection);
        }
    }
}
