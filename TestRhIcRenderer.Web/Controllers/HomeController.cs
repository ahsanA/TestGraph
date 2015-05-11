using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRhIcRenderer.Web.Models;

namespace TestRhIcRenderer.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult FetchGraphData()
        {
            var data = new List<Statistics>  
                        {  
                            new Statistics{Day = "1-Nov-2012", Value = 10},  
                            new Statistics{Day = "2-Nov-2012", Value = 20},  
                            new Statistics{Day = "3-Nov-2012", Value = 22},  
                            new Statistics{Day = "4-Nov-2012", Value = 15},  
                            new Statistics{Day = "5-Nov-2012", Value = 40},  
                            new Statistics{Day = "6-Nov-2012", Value = 1},  
                            new Statistics{Day = "7-Nov-2012", Value = 0},  
                            new Statistics{Day = "8-Nov-2012", Value = 3},  
                            new Statistics{Day = "9-Nov-2012", Value = 11},  
                            new Statistics{Day = "10-Nov-2012", Value = 22},  
                            new Statistics{Day = "11-Nov-2012", Value = 33},  
                            new Statistics{Day = "12-Nov-2012", Value = 44},  
                            new Statistics{Day = "13-Nov-2012", Value = 44},  
                            new Statistics{Day = "14-Nov-2012", Value = 44},  
                            new Statistics{Day = "15-Nov-2012", Value = 44},  
                        };

            var amountList = new List<int>();
            var dayList = new List<string>();

            foreach (var item in data)
            {
                dayList.Add(item.Day);
                amountList.Add(item.Value);
            }

            return Json(new { stats = amountList, days = dayList }, JsonRequestBehavior.AllowGet);
        }

        public class Statistics
        {
            public int Value { get; set; }
            public string Day { get; set; }
        }

        public ActionResult FetchGraphDataOHLC()
        {
            var data = new List<DataModel>
            {
                new DataModel
                {
                    Date = "06/15/2009",
                    Open = 136.01,
                    HighRate = 139.5,
                    LowRate = 134.53,
                    Close = 139.48,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "06/08/2009",
                    Open = 143.82,
                    HighRate = 144.56,
                    LowRate = 136.04,
                    Close = 136.97,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "06/01/2009",
                    Open = 136.47,
                    HighRate = 146.4,
                    LowRate = 136,
                    Close = 144.67,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "05/26/2009",
                    Open = 124.76,
                    HighRate = 135.9,
                    LowRate = 124.55,
                    Close = 135.81,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "05/18/2009",
                    Open = 123.73,
                    HighRate = 129.31,
                    LowRate = 121.57,
                    Close = 122.5,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "05/11/2009",
                    Open = 127.37,
                    HighRate = 130.96,
                    LowRate = 119.38,
                    Close = 122.42,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "05/04/2009",
                    Open = 128.24,
                    HighRate = 133.5,
                    LowRate = 126.26,
                    Close = 129.19,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "04/27/2009",
                    Open = 122.9,
                    HighRate = 127.95,
                    LowRate = 122.66,
                    Close = 127.24,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "04/20/2009",
                    Open = 121.73,
                    HighRate = 127.2,
                    LowRate = 118.6,
                    Close = 123.9,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "04/13/2009",
                    Open = 120.01,
                    HighRate = 124.25,
                    LowRate = 115.76,
                    Close = 123.42,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "04/06/2009",
                    Open = 114.94,
                    HighRate = 120,
                    LowRate = 113.28,
                    Close = 119.57,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "03/30/2009",
                    Open = 104.51,
                    HighRate = 116.13,
                    LowRate = 102.61,
                    Close = 115.99,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "03/23/2009",
                    Open = 102.71,
                    HighRate = 109.98,
                    LowRate = 101.75,
                    Close = 106.85,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "03/16/2009",
                    Open = 96.53,
                    HighRate = 103.48,
                    LowRate = 94.18,
                    Close = 101.59,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "03/09/2009",
                    Open = 84.18,
                    HighRate = 97.2,
                    LowRate = 82.57,
                    Close = 95.93,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "03/02/2009",
                    Open = 88.12,
                    HighRate = 92.77,
                    LowRate = 82.33,
                    Close = 85.3,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "02/23/2009",
                    Open = 91.65,
                    HighRate = 92.92,
                    LowRate = 86.51,
                    Close = 89.31,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "02/17/2009",
                    Open = 96.87,
                    HighRate = 97.04,
                    LowRate = 89,
                    Close = 91.2,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "02/09/2009",
                    Open = 100,
                    HighRate = 103,
                    LowRate = 95.77,
                    Close = 99.16,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "02/02/2009",
                    Open = 89.1,
                    HighRate = 100,
                    LowRate = 88.9,
                    Close = 99.72,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "01/26/2009",
                    Open = 88.86,
                    HighRate = 95,
                    LowRate = 88.3,
                    Close = 90.13,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "01/20/2009",
                    Open = 81.93,
                    HighRate = 90,
                    LowRate = 78.2,
                    Close = 88.36,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "01/12/2009",
                    Open = 90.46,
                    HighRate = 90.99,
                    LowRate = 80.05,
                    Close = 82.33,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "01/05/2009",
                    Open = 93.17,
                    HighRate = 97.17,
                    LowRate = 90.04,
                    Close = 90.58,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "12/29/2008",
                    Open = 86.52,
                    HighRate = 91.04,
                    LowRate = 84.72,
                    Close = 90.75,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "12/22/2008",
                    Open = 90.02,
                    HighRate = 90.03,
                    LowRate = 84.55,
                    Close = 85.81,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "12/15/2008",
                    Open = 95.99,
                    HighRate = 96.48,
                    LowRate = 88.02,
                    Close = 90,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "12/08/2008",
                    Open = 97.28,
                    HighRate = 103.6,
                    LowRate = 92.53,
                    Close = 98.27,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "12/01/2008",
                    Open = 91.3,
                    HighRate = 96.23,
                    LowRate = 86.5,
                    Close = 94,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "11/24/2008",
                    Open = 85.21,
                    HighRate = 95.25,
                    LowRate = 84.84,
                    Close = 92.67,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "11/17/2008",
                    Open = 88.48,
                    HighRate = 91.58,
                    LowRate = 79.14,
                    Close = 82.58,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "11/10/2008",
                    Open = 100.17,
                    HighRate = 100.4,
                    LowRate = 86.02,
                    Close = 90.24,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "11/03/2008",
                    Open = 105.93,
                    HighRate = 111.79,
                    LowRate = 95.72,
                    Close = 98.24,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "10/27/2008",
                    Open = 95.07,
                    HighRate = 112.19,
                    LowRate = 91.86,
                    Close = 107.59,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "10/20/2008",
                    Open = 99.78,
                    HighRate = 101.25,
                    LowRate = 90.11,
                    Close = 96.38,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "10/13/2008",
                    Open = 104.55,
                    HighRate = 116.4,
                    LowRate = 85.89,
                    Close = 97.4,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "10/06/2008",
                    Open = 91.96,
                    HighRate = 101.5,
                    LowRate = 85,
                    Close = 96.8,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "09/29/2008",
                    Open = 119.62,
                    HighRate = 119.68,
                    LowRate = 94.65,
                    Close = 97.07,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "09/22/2008",
                    Open = 139.94,
                    HighRate = 140.25,
                    LowRate = 123,
                    Close = 128.24,
                    Countryname = "Germany"
                },
                new DataModel
                {
                    Date = "09/15/2008",
                    Open = 142.03,
                    HighRate = 147.69,
                    LowRate = 120.68,
                    Close = 140.91,
                    Countryname = "Germany"
                }
            };

            var ohlc = "[";
            var firstItem = true;
            foreach (var item in data)
            {
                if (firstItem)
                {
                    ohlc += "['" + item.Date + "', " + item.Open + ", " + item.HighRate + ", " + item.LowRate + ", " +
                            item.Close + "]";
                    firstItem = false;
                }
                else
                {
                    ohlc += ",['" + item.Date + "', " + item.Open + ", " + item.HighRate + ", " + item.LowRate + ", " +
                            item.Close + "]";
                }

            }
            ohlc += "]";
            return Json(ohlc, JsonRequestBehavior.AllowGet);
        }
    }
}