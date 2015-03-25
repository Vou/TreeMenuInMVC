using System.Collections.Generic;

namespace MvcApplication1.Models
{
    public class Database
    {
        public static IEnumerable<CarCategory> GetAllCarCategories()
        {
            return new List<CarCategory>
            {
                new CarCategory(){Id = 1, ParentId = 0, Name = "奥迪",FirstLetter = "A", AnchorName = "AA", Level = 1, DelFlag = 0},
                new CarCategory(){Id = 2, ParentId = 0, Name = "宝马",FirstLetter = "B", AnchorName = "BB", Level = 1, DelFlag = 0},
                new CarCategory(){Id = 3, ParentId = 0, Name = "保时捷",FirstLetter = "B", AnchorName = "BB", Level = 1, DelFlag = 0},
                new CarCategory(){Id = 4, ParentId = 0, Name = "长安",FirstLetter = "C", AnchorName = "CC", Level = 1, DelFlag = 0},
                new CarCategory(){Id = 5, ParentId = 0, Name = "大众",FirstLetter = "D", AnchorName = "DD", Level = 1, DelFlag = 0},
                new CarCategory(){Id = 6, ParentId = 0, Name = "东风",FirstLetter = "D", AnchorName = "DD", Level = 1, DelFlag = 0},
                new CarCategory(){Id = 7, ParentId = 0, Name = "丰田",FirstLetter = "F", AnchorName = "FF", Level = 1, DelFlag = 0},
                new CarCategory(){Id = 8, ParentId = 0, Name = "福特",FirstLetter = "F", AnchorName = "FF", Level = 1, DelFlag = 0},

                new CarCategory(){Id = 9, ParentId = 1, Name = "奥迪A4",FirstLetter = "A", AnchorName = "AA", Level = 2, DelFlag = 0},
                new CarCategory(){Id = 10, ParentId = 1, Name = "奥迪A6",FirstLetter = "A", AnchorName = "AA", Level = 2, DelFlag = 0},

                new CarCategory(){Id = 11, ParentId = 2, Name = "宝马1",FirstLetter = "B", AnchorName = "BB", Level = 2, DelFlag = 0},
                new CarCategory(){Id = 12, ParentId = 2, Name = "宝马2",FirstLetter = "B", AnchorName = "BB", Level = 2, DelFlag = 0},

                new CarCategory(){Id = 13, ParentId = 3, Name = "保时捷1",FirstLetter = "B", AnchorName = "BB", Level = 2, DelFlag = 0},
                new CarCategory(){Id = 14, ParentId = 3, Name = "保时捷2",FirstLetter = "B", AnchorName = "BB", Level = 2, DelFlag = 0},

                new CarCategory(){Id = 15, ParentId = 4, Name = "长安1",FirstLetter = "C", AnchorName = "CC", Level = 2, DelFlag = 0},
                new CarCategory(){Id = 16, ParentId = 4, Name = "长安2",FirstLetter = "C", AnchorName = "CC", Level = 2, DelFlag = 0},

                new CarCategory(){Id = 17, ParentId = 5, Name = "大众1",FirstLetter = "D", AnchorName = "DD", Level = 2, DelFlag = 0},
                new CarCategory(){Id = 18, ParentId = 5, Name = "大众2",FirstLetter = "D", AnchorName = "DD", Level = 2, DelFlag = 1},

                new CarCategory(){Id = 19, ParentId = 6, Name = "东风1",FirstLetter = "D", AnchorName = "DD", Level = 2, DelFlag = 0},
                new CarCategory(){Id = 20, ParentId = 6, Name = "东风2",FirstLetter = "D", AnchorName = "DD", Level = 2, DelFlag = 0},

                new CarCategory(){Id = 21, ParentId = 7, Name = "丰田1",FirstLetter = "F", AnchorName = "FF", Level = 2, DelFlag = 0},
                new CarCategory(){Id = 22, ParentId = 7, Name = "丰田2",FirstLetter = "F", AnchorName = "FF", Level = 2, DelFlag = 0},

                new CarCategory(){Id = 23, ParentId = 8, Name = "福特1",FirstLetter = "F", AnchorName = "AFF", Level = 2, DelFlag = 0},
                new CarCategory(){Id = 24, ParentId = 8, Name = "福特2",FirstLetter = "F", AnchorName = "AFF", Level = 2, DelFlag = 0}
            };
        }

        public static IEnumerable<Car> GetAllCars()
        {
            return new List<Car>
            {
                new Car(){Id = 1, PinPaiId = 1, CheXiId = 9, Name = "奥迪A401"},
                new Car(){Id = 2, PinPaiId = 1, CheXiId = 9, Name = "奥迪A402"},
                new Car(){Id = 3, PinPaiId = 1, CheXiId = 10, Name = "奥迪A601"},
                new Car(){Id = 4, PinPaiId = 1, CheXiId = 10, Name = "奥迪A602"},

                new Car(){Id = 5, PinPaiId = 2, CheXiId = 11, Name = "宝马101"},
                new Car(){Id = 6, PinPaiId = 2, CheXiId = 11, Name = "宝马102"},
                new Car(){Id = 7, PinPaiId = 2, CheXiId = 12, Name = "宝马201"},
                new Car(){Id = 8, PinPaiId = 2, CheXiId = 12, Name = "宝马202"},

                new Car(){Id = 9, PinPaiId = 3, CheXiId = 13, Name = "保时捷101"},
                new Car(){Id = 10, PinPaiId = 3, CheXiId = 13, Name = "保时捷102"},
                new Car(){Id = 11, PinPaiId = 3, CheXiId = 14, Name = "保时捷201"},
                new Car(){Id = 12, PinPaiId = 3, CheXiId = 14, Name = "保时捷202"},

                new Car(){Id = 13, PinPaiId = 4, CheXiId = 15, Name = "长安101"},
                new Car(){Id = 14, PinPaiId = 4, CheXiId = 15, Name = "长安102"},
                new Car(){Id = 15, PinPaiId = 4, CheXiId = 16, Name = "长安201"},
                new Car(){Id = 16, PinPaiId = 4, CheXiId = 16, Name = "长安202"},

                new Car(){Id = 17, PinPaiId = 5, CheXiId = 17, Name = "大众101"},
                new Car(){Id = 18, PinPaiId = 5, CheXiId = 17, Name = "大众102"},
                new Car(){Id = 19, PinPaiId = 5, CheXiId = 18, Name = "大众201"},
                new Car(){Id = 20, PinPaiId = 5, CheXiId = 18, Name = "大众202"},

                new Car(){Id = 21, PinPaiId = 6, CheXiId = 19, Name = "东风101"},
                new Car(){Id = 22, PinPaiId = 6, CheXiId = 19, Name = "东风102"},
                new Car(){Id = 23, PinPaiId = 6, CheXiId = 20, Name = "东风201"},
                new Car(){Id = 24, PinPaiId = 6, CheXiId = 20, Name = "东风202"},

                new Car(){Id = 25, PinPaiId = 7, CheXiId = 21, Name = "丰田101"},
                new Car(){Id = 26, PinPaiId = 7, CheXiId = 21, Name = "丰田102"},
                new Car(){Id = 27, PinPaiId = 7, CheXiId = 22, Name = "丰田201"},
                new Car(){Id = 28, PinPaiId = 7, CheXiId = 22, Name = "丰田202"},

                new Car(){Id = 29, PinPaiId = 8, CheXiId = 23, Name = "福特101"},
                new Car(){Id = 30, PinPaiId = 8, CheXiId = 23, Name = "福特102"},
                new Car(){Id = 31, PinPaiId = 8, CheXiId = 24, Name = "福特201"},
                new Car(){Id = 32, PinPaiId = 8, CheXiId = 24, Name = "福特202"}
            };
        }
    }
}