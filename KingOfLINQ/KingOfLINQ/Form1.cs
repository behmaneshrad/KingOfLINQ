using KingOfLINQ.Helper;
using System.Diagnostics;

namespace KingOfLINQ
{
    public partial class frmMain : Form
    {
        private Pet[] Pets =
               new[]
               {
                    new Pet(1,"Rex",PetType.Cat,1.9f),
                    new Pet(2,"Lucky",PetType.Dog,4f),
                    new Pet(3,"Storm",PetType.Dog,0.9f),
                     new Pet(3,"Sun",PetType.Dog,3.9f),
                     new Pet(7,"Cute",PetType.Dog,3.9f),
                      new Pet(1,"Mex",PetType.Cat,1.3f)
               };

        private Pet[] YoungPets =
               new[]
               {
                    new Pet(1,"Yeo",PetType.Cat,0.3f),
                    new Pet(4,"Teo",PetType.Dog,0.5f),
                    new Pet(5,"Neo",PetType.Dog,0.6f)
               };

        private PetOwner[] PetOwners =
            new[]
            {
                new PetOwner("Alex",2),
                new PetOwner("Nick",7),

            };


        private string[] sentences = { "hi", "my", "name's", "Alireza", "Behmaneshrad" };
        private int[] Ids = { 1, 2, 3, 4, 5 };


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFrm000_Click(object sender, EventArgs e)
        {

        }

        private static bool IsAny(int[] numbers, Func<int, bool> predicate)
        {
            foreach (var number in numbers)
            {
                if (predicate(number))
                    return true;
            }

            return false;
        }

        public static bool IsAnyLargerThan20(int number)
        {
            return number > 20;
        }

        public static bool IsAnyEven(int number)
        {
            return number % 2 == 0;
        }

        private void btnIntroduction_Click(object sender, EventArgs e)
        {

            /*
             * Takeaway:
             * 1.Lambda expressions allow us to create anonymous functions.
             *  2.In C# we can use functions like any other types - store them in variables or pass as parameters.
             *             
             */



            string msg = "";
            var numbers = new[] { 3, 21, 13, 49, 7, 35, 1 };

            bool isAnyLargerThan20 = true;

            msg = $"Is any Larger than 20 By Func : { IsAny(numbers, IsAnyLargerThan20) } \n";

            msg += $"Is any Larger than 20 By Linq From1: { IsAny(numbers, number => number > 20) } \n";


            bool isAny = IsAny(numbers, number =>
            {
                const int max = 20;
                return number > max;
            });

            msg += $"Is any Larger than 20 By Linq Form2: { isAny } \n";

            Func<int, bool> IsAnyLargerThan20Fn = number => number > 20;
            msg += $"Is any Larger than 20 By Linq From3: { IsAny(numbers, IsAnyLargerThan20Fn) } \n";

            bool isAnyEven = false;
            msg += $"Is any Even : { IsAny(numbers, IsAnyEven) } \n";

            msg += $"Is any Even By Linq: { IsAny(numbers, number => number % 2 == 0) } \n";

            MessageBox.Show(msg);
        }

        private void btnLinqAndExtensionMethods_Click(object sender, EventArgs e)
        {
            /*
             * Takeaway:
             *  1.An extension method is method defined outside of a type, that can be called upon this type's objects as regular member method.
             *  2.Deferred execution means that the evalution of a LINQ expression is delayed until the value is actually needed.
             */


            string msg = "";

            var words = new[] { "You", "are", "so", "cool", "!" };

            var wordsLongerThan2Letters = words.Where(word => word.Length > 2);

            msg += String.Join(", ", wordsLongerThan2Letters) + " \n";

            string multiString = @"hi
                                    My name's Alireza behmaneshrad
                                    I'm back end developer
                                    please follow me";

            var countOfLines = multiString.GetCountOfLines();

            msg += $"Count Of Lines: {countOfLines}";

            MessageBox.Show(msg);
        }

        private void btnAny_Click(object sender, EventArgs e)
        {


            var isAnyCat = Pets.Any(x => x.PetType == PetType.Cat);

            Printer.Print(isAnyCat, nameof(isAnyCat));
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            var areAllCats = Pets.All(pet => pet.PetType == PetType.Dog);

            Printer.Print(areAllCats, nameof(areAllCats));
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var countOfDogs = Pets.Count(pet => pet.PetType == PetType.Dog);//Count - LongCount

            Printer.Print(countOfDogs, nameof(countOfDogs));
        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            var rex = new Pet(1, "Rex", PetType.Dog, 1);

            var containRex = Pets.Contains(rex, new PetComparerById());

            Printer.Print(containRex, nameof(containRex));

        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            var petsOrderedByTypeComparer = Pets.OrderBy(pet => pet, new PetByTypeComparer());

            Printer.Print(petsOrderedByTypeComparer, nameof(petsOrderedByTypeComparer));
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            var MinOfWeight = Pets.Min(pet => pet.Weight);

            Printer.Print(MinOfWeight, nameof(MinOfWeight));
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            var AverageOfWeight = Pets.Average(pet => pet.Weight);

            Printer.Print(AverageOfWeight, nameof(AverageOfWeight));
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            var SumOfWeight = Pets.Sum(pet => pet.Weight);

            Printer.Print(SumOfWeight, nameof(SumOfWeight));
        }

        private void btnElementAt_Click(object sender, EventArgs e)
        {
            var ElementOfPets = Pets.ElementAtOrDefault(3);

            Printer.Print(ElementOfPets, nameof(ElementOfPets));
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            var firstOdd = Pets.FirstOrDefault(pet => pet.Weight % 2 == 0);

            Printer.Print(firstOdd, nameof(firstOdd));
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            var singleCat = Pets.SingleOrDefault(pet => pet.PetType == PetType.Dog);

            Printer.Print(singleCat, nameof(singleCat));
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            var catWeight = Pets.Where(pet => pet.Weight > 1);

            Printer.Print(catWeight, nameof(catWeight));
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            var catWeight2 = Pets.TakeWhile(pet => pet.Weight < 2).Skip(1);

            Printer.Print(catWeight2, nameof(catWeight2));


            var sixtyPercentOfPets = Pets.Take((int)(Pets.Count() * 0.8));

            Printer.Print(sixtyPercentOfPets, nameof(sixtyPercentOfPets));
        }

        private void btnOfType_Click(object sender, EventArgs e)
        {
            var objects = new object[]
            {
                null,
                1,
                "you",
                3.3,
                true,
                "are",
                new List<int>(),
                "celever"
            };

            var str = objects.OfType<string>();
            Printer.Print(str, nameof(str));

        }

        private void btnDistinct_Click(object sender, EventArgs e)
        {
            var pets = Pets.Distinct(new PetComparerById());
            Printer.Print(pets, nameof(pets));
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {

            var pr = Pets.Prepend(new Pet(0, "Hopy", PetType.Dog, 1.5f));
            var ap = pr.Append(new Pet(4, "Mey", PetType.Cat, 0.8f));


            Printer.Print(ap, nameof(ap));
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            var list1 = new List<int> { 1, 2, 3 };
            var list2 = new List<int> { 2, 3, 4, 5 };

            list1 = list1.Concat(list2).ToList();

            Printer.Print(list1, nameof(list1));
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {

            var list1 = Pets.Union(YoungPets).ToList();

            Printer.Print(list1, nameof(list1));


            var list2 = Pets.Union(YoungPets, new PetComparerById()).ToList();

            Printer.Print(list2, nameof(list2));

        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            var listInt = new List<int> { 1, 2, 3, 3, 4, 4, 5 };
            var listIntToHashSet = listInt.ToHashSet();
            Printer.Print(listIntToHashSet, nameof(listIntToHashSet));

            var listPetsToHashSet = Pets.ToHashSet(new PetComparerById());
            Printer.Print(listPetsToHashSet, nameof(listPetsToHashSet));

            var listIntToLookup = listInt.ToLookup(x => x % 2 == 0);
            Printer.Print(listIntToLookup[true].ToList(), nameof(listIntToLookup));

            var listPetsToLookup = Pets.ToLookup(x => x.PetType == PetType.Cat);
            Printer.Print(listPetsToLookup[true].ToList(), nameof(listPetsToLookup));

            var listPetsToDictionary = Pets.ToDictionary(pet => pet.Name, pet => pet.PetType);//Name is Uniqe
            Printer.Print(listPetsToDictionary, nameof(listPetsToDictionary));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var list = new int[] { 1, 44, 6, 81 };
            var doubleNumbers = list.Select((item, index) => $"[{index + 1}] : {item * 2}");
            Printer.Print(doubleNumbers, nameof(doubleNumbers));
        }

        private void btnSelectMany_Click(object sender, EventArgs e)
        {
            List<List<string>> cities = new List<List<string>>()
            {
             new List<string>(){ "city1" , "city2" , "city3" },
             new List<string>(){ "city4" , "city5"}
            };

            var flattenedList = cities.SelectMany(list => list);
            Printer.Print(flattenedList, nameof(flattenedList));
        }

        private void btnNewGeneration_Click(object sender, EventArgs e)
        {
            var emptyInts = Enumerable.Empty<int>();
            Printer.Print(emptyInts, nameof(emptyInts));

            var repeatInts = Enumerable.Repeat(1, 5);
            Printer.Print(repeatInts, nameof(repeatInts));

            var rangeInts = Enumerable.Range(5, 5);
            Printer.Print(rangeInts, nameof(rangeInts));

        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            var petsGroup = Pets.GroupBy(pet => pet.PetType, pet => pet.PetType + " " + pet.Name);
            Printer.Print(petsGroup.First().ToList(), nameof(petsGroup));
        }

        private void btnIntersect_Click(object sender, EventArgs e)
        {
            var collection1 = new[] { 1, 2, 3, 4, 5 };
            var collection2 = new[] { 11, 5, 3, 5 };

            var collection = collection2.Intersect(collection1);
            Printer.Print(collection, nameof(collection));
        }

        private void btnExcept_Click(object sender, EventArgs e)
        {
            var collection1 = new[] { 1, 2, 3, 4, 5 };
            var collection2 = new[] { 11, 5, 3, 5 };

            var collection = collection2.Except(collection1);
            Printer.Print(collection, nameof(collection));
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var InnerJoin = Pets.Join(
                PetOwners,
                pet => pet.Id,
                owner => owner.PetId,
                (pet, owner) => new
                {
                    PetName = pet.Name,
                    OwnerFullName = owner.FullName
                }
            );

            Printer.Print(InnerJoin, nameof(InnerJoin));
        }

        private void btnGroupJoin_Click(object sender, EventArgs e)
        {

            var GroupJoin = Pets.GroupJoin(
                PetOwners,
                pet => pet.Id,
                owner => owner.PetId,
                (pet, owner) => new
                {
                    PetName = pet.Name,
                    OwnerFullName = owner.Select(owner => owner.FullName).FirstOrDefault() ?? "No Owner"
                }
            );

            Printer.Print(GroupJoin, nameof(GroupJoin));

        }

        private void btnAggregate_Click(object sender, EventArgs e)
        {

            var aggregateFunction = sentences.Aggregate(
                (resultSoFar, nextLetter) => $"{resultSoFar} {nextLetter}"
                );

            Printer.Print(aggregateFunction, nameof(aggregateFunction));
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            var zipFunction = Ids.Zip(
                sentences,
                (number, word) => $"{number}.{word}");

            Printer.Print(zipFunction, nameof(zipFunction));

        }

        private double getSqrt(int number)
        {
            return Math.Sqrt(number);
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            var queryOrderBy = (from number in Ids
                                let sqrt = getSqrt(number)
                                orderby sqrt descending
                                select sqrt).Reverse();

            Printer.Print(queryOrderBy, nameof(queryOrderBy));
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            var nestedList = new List<List<int>>
            {
                new List<int> {1,2,3},
                new List<int> {4,5},
                new List<int> {6,7,8,9},
            };

            var querySelectMany = from list in nestedList
                                  from numbers in list
                                  select numbers;

            Printer.Print(querySelectMany, nameof(querySelectMany));
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            var queryGroupBy = from pet in Pets
                               group pet by Math.Floor(pet.Weight) into grouping
                               orderby grouping.Key
                               let petsOrderByWeight = from pet in grouping
                                                       orderby pet.Weight
                                                       select pet
                               select new
                               {
                                   Key = grouping.Key,
                                   LightestPet = petsOrderByWeight.First(),
                                   HeaviestPet = petsOrderByWeight.Last()
                               };
            var result = from petWeightGroup in queryGroupBy
                         select $"Weight Category : {petWeightGroup.Key} " +
                         $"HeaviestPet: {petWeightGroup.HeaviestPet.Name} " +
                         $"LightestPet: {petWeightGroup.LightestPet.Name} ";
                         

            Printer.Print(result, nameof(queryGroupBy));
        }

        private void btnQueryInnerJoin_Click(object sender, EventArgs e)
        {
           

            var queryInnerJoin = from pet in Pets
                                 join owner in PetOwners
                                 on pet.Id equals owner.PetId
                                 select $"PetName : {pet.Name} - OwnerFullName : {owner.FullName} ";

            Printer.Print(queryInnerJoin, nameof(queryInnerJoin));
        }

        private void btnQueryLeftJoin_Click(object sender, EventArgs e)
        {
            var queryLeftJoin = from pet in Pets
                                join owner in PetOwners
                                on pet.Id equals owner.PetId into petWithOwner
                                from owner in petWithOwner.DefaultIfEmpty()
                                select new
                                {
                                    PetName = pet.Name,
                                    OwnerFullName = owner != null ? owner.FullName : "No Owner"
                                };

            Printer.Print(queryLeftJoin, nameof(queryLeftJoin));
        }

        
    }
}