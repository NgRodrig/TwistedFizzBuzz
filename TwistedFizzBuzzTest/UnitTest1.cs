namespace TwistedFizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClassicFizzBuzz()
        {
            string assertString = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n16\r\n17\r\nFizz\r\n19\r\nBuzz\r\nFizz\r\n22\r\n23\r\nFizz\r\nBuzz\r\n26\r\nFizz\r\n28\r\n29\r\nFizzBuzz\r\n31\r\n32\r\nFizz\r\n34\r\nBuzz\r\nFizz\r\n37\r\n38\r\nFizz\r\nBuzz\r\n41\r\nFizz\r\n43\r\n44\r\nFizzBuzz\r\n46\r\n47\r\nFizz\r\n49\r\nBuzz\r\nFizz\r\n52\r\n53\r\nFizz\r\nBuzz\r\n56\r\nFizz\r\n58\r\n59\r\nFizzBuzz\r\n61\r\n62\r\nFizz\r\n64\r\nBuzz\r\nFizz\r\n67\r\n68\r\nFizz\r\nBuzz\r\n71\r\nFizz\r\n73\r\n74\r\nFizzBuzz\r\n76\r\n77\r\nFizz\r\n79\r\nBuzz\r\nFizz\r\n82\r\n83\r\nFizz\r\nBuzz\r\n86\r\nFizz\r\n88\r\n89\r\nFizzBuzz\r\n91\r\n92\r\nFizz\r\n94\r\nBuzz\r\nFizz\r\n97\r\n98\r\nFizz\r\nBuzz\r\n";
            Assert.AreEqual(TwistedFizzBuzz.FizzBuzz.Classic(1,100),assertString);
        }

        [TestMethod]
        public void GeneralUsageFizzBuzz()
        {
            string assertString = "FizzBuzz\r\n-149\r\n-148\r\nFizz\r\n-146\r\nBuzz\r\nFizz\r\n-143\r\n-142\r\nFizz\r\nBuzz\r\n-139\r\nFizz\r\n-137\r\n-136\r\nFizzBuzz\r\n-134\r\n-133\r\nFizz\r\n-131\r\nBuzz\r\nFizz\r\n-128\r\n-127\r\nFizz\r\nBuzz\r\n-124\r\nFizz\r\n-122\r\n-121\r\nFizzBuzz\r\n-119\r\n-118\r\nFizz\r\n-116\r\nBuzz\r\nFizz\r\n-113\r\n-112\r\nFizz\r\nBuzz\r\n-109\r\nFizz\r\n-107\r\n-106\r\nFizzBuzz\r\n-104\r\n-103\r\nFizz\r\n-101\r\nBuzz\r\nFizz\r\n-98\r\n-97\r\nFizz\r\nBuzz\r\n-94\r\nFizz\r\n-92\r\n-91\r\nFizzBuzz\r\n-89\r\n-88\r\nFizz\r\n-86\r\nBuzz\r\nFizz\r\n-83\r\n-82\r\nFizz\r\nBuzz\r\n-79\r\nFizz\r\n-77\r\n-76\r\nFizzBuzz\r\n-74\r\n-73\r\nFizz\r\n-71\r\nBuzz\r\nFizz\r\n-68\r\n-67\r\nFizz\r\nBuzz\r\n-64\r\nFizz\r\n-62\r\n-61\r\nFizzBuzz\r\n-59\r\n-58\r\nFizz\r\n-56\r\nBuzz\r\nFizz\r\n-53\r\n-52\r\nFizz\r\nBuzz\r\n-49\r\nFizz\r\n-47\r\n-46\r\nFizzBuzz\r\n-44\r\n-43\r\nFizz\r\n-41\r\nBuzz\r\nFizz\r\n-38\r\n-37\r\nFizz\r\nBuzz\r\n-34\r\nFizz\r\n-32\r\n-31\r\nFizzBuzz\r\n-29\r\n-28\r\nFizz\r\n-26\r\nBuzz\r\nFizz\r\n-23\r\n-22\r\nFizz\r\nBuzz\r\n-19\r\nFizz\r\n-17\r\n-16\r\nFizzBuzz\r\n-14\r\n-13\r\nFizz\r\n-11\r\nBuzz\r\nFizz\r\n-8\r\n-7\r\nFizz\r\nBuzz\r\n-4\r\nFizz\r\n-2\r\n-1\r\nFizzBuzz\r\n1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n16\r\n17\r\nFizz\r\n19\r\nBuzz\r\nFizz\r\n22\r\n23\r\nFizz\r\nBuzz\r\n26\r\nFizz\r\n28\r\n29\r\nFizzBuzz\r\n31\r\n32\r\nFizz\r\n34\r\nBuzz\r\nFizz\r\n37\r\n38\r\nFizz\r\nBuzz\r\n41\r\nFizz\r\n43\r\n44\r\nFizzBuzz\r\n46\r\n47\r\nFizz\r\n49\r\nBuzz\r\nFizz\r\n52\r\n53\r\nFizz\r\nBuzz\r\n56\r\nFizz\r\n58\r\n59\r\nFizzBuzz\r\n61\r\n62\r\nFizz\r\n64\r\nBuzz\r\nFizz\r\n67\r\n68\r\nFizz\r\nBuzz\r\n71\r\nFizz\r\n73\r\n74\r\nFizzBuzz\r\n76\r\n77\r\nFizz\r\n79\r\nBuzz\r\nFizz\r\n82\r\n83\r\nFizz\r\nBuzz\r\n86\r\nFizz\r\n88\r\n89\r\nFizzBuzz\r\n91\r\n92\r\nFizz\r\n94\r\nBuzz\r\nFizz\r\n97\r\n98\r\nFizz\r\nBuzz\r\n101\r\nFizz\r\n103\r\n104\r\nFizzBuzz\r\n106\r\n107\r\nFizz\r\n109\r\nBuzz\r\nFizz\r\n112\r\n113\r\nFizz\r\nBuzz\r\n116\r\nFizz\r\n118\r\n119\r\nFizzBuzz\r\n121\r\n122\r\nFizz\r\n124\r\nBuzz\r\nFizz\r\n127\r\n128\r\nFizz\r\nBuzz\r\n131\r\nFizz\r\n133\r\n134\r\nFizzBuzz\r\n136\r\n137\r\nFizz\r\n139\r\nBuzz\r\nFizz\r\n142\r\n143\r\nFizz\r\nBuzz\r\n146\r\nFizz\r\n148\r\n149\r\nFizzBuzz\r\n";

            List<string> tokens = new() { "Fizz", "Buzz" };

            List<int> divisors = new() { 3, 5 };

            Assert.AreEqual(TwistedFizzBuzz.FizzBuzz.GeneralUsage(-150,150,divisors,tokens), assertString);
        }

        [TestMethod]
        public void GeneralUsageFizzBuzzInvertedRange()
        {
            string assertString = "FizzBuzz\r\n-149\r\n-148\r\nFizz\r\n-146\r\nBuzz\r\nFizz\r\n-143\r\n-142\r\nFizz\r\nBuzz\r\n-139\r\nFizz\r\n-137\r\n-136\r\nFizzBuzz\r\n-134\r\n-133\r\nFizz\r\n-131\r\nBuzz\r\nFizz\r\n-128\r\n-127\r\nFizz\r\nBuzz\r\n-124\r\nFizz\r\n-122\r\n-121\r\nFizzBuzz\r\n-119\r\n-118\r\nFizz\r\n-116\r\nBuzz\r\nFizz\r\n-113\r\n-112\r\nFizz\r\nBuzz\r\n-109\r\nFizz\r\n-107\r\n-106\r\nFizzBuzz\r\n-104\r\n-103\r\nFizz\r\n-101\r\nBuzz\r\nFizz\r\n-98\r\n-97\r\nFizz\r\nBuzz\r\n-94\r\nFizz\r\n-92\r\n-91\r\nFizzBuzz\r\n-89\r\n-88\r\nFizz\r\n-86\r\nBuzz\r\nFizz\r\n-83\r\n-82\r\nFizz\r\nBuzz\r\n-79\r\nFizz\r\n-77\r\n-76\r\nFizzBuzz\r\n-74\r\n-73\r\nFizz\r\n-71\r\nBuzz\r\nFizz\r\n-68\r\n-67\r\nFizz\r\nBuzz\r\n-64\r\nFizz\r\n-62\r\n-61\r\nFizzBuzz\r\n-59\r\n-58\r\nFizz\r\n-56\r\nBuzz\r\nFizz\r\n-53\r\n-52\r\nFizz\r\nBuzz\r\n-49\r\nFizz\r\n-47\r\n-46\r\nFizzBuzz\r\n-44\r\n-43\r\nFizz\r\n-41\r\nBuzz\r\nFizz\r\n-38\r\n-37\r\nFizz\r\nBuzz\r\n-34\r\nFizz\r\n-32\r\n-31\r\nFizzBuzz\r\n-29\r\n-28\r\nFizz\r\n-26\r\nBuzz\r\nFizz\r\n-23\r\n-22\r\nFizz\r\nBuzz\r\n-19\r\nFizz\r\n-17\r\n-16\r\nFizzBuzz\r\n-14\r\n-13\r\nFizz\r\n-11\r\nBuzz\r\nFizz\r\n-8\r\n-7\r\nFizz\r\nBuzz\r\n-4\r\nFizz\r\n-2\r\n-1\r\nFizzBuzz\r\n1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n16\r\n17\r\nFizz\r\n19\r\nBuzz\r\nFizz\r\n22\r\n23\r\nFizz\r\nBuzz\r\n26\r\nFizz\r\n28\r\n29\r\nFizzBuzz\r\n31\r\n32\r\nFizz\r\n34\r\nBuzz\r\nFizz\r\n37\r\n38\r\nFizz\r\nBuzz\r\n41\r\nFizz\r\n43\r\n44\r\nFizzBuzz\r\n46\r\n47\r\nFizz\r\n49\r\nBuzz\r\nFizz\r\n52\r\n53\r\nFizz\r\nBuzz\r\n56\r\nFizz\r\n58\r\n59\r\nFizzBuzz\r\n61\r\n62\r\nFizz\r\n64\r\nBuzz\r\nFizz\r\n67\r\n68\r\nFizz\r\nBuzz\r\n71\r\nFizz\r\n73\r\n74\r\nFizzBuzz\r\n76\r\n77\r\nFizz\r\n79\r\nBuzz\r\nFizz\r\n82\r\n83\r\nFizz\r\nBuzz\r\n86\r\nFizz\r\n88\r\n89\r\nFizzBuzz\r\n91\r\n92\r\nFizz\r\n94\r\nBuzz\r\nFizz\r\n97\r\n98\r\nFizz\r\nBuzz\r\n101\r\nFizz\r\n103\r\n104\r\nFizzBuzz\r\n106\r\n107\r\nFizz\r\n109\r\nBuzz\r\nFizz\r\n112\r\n113\r\nFizz\r\nBuzz\r\n116\r\nFizz\r\n118\r\n119\r\nFizzBuzz\r\n121\r\n122\r\nFizz\r\n124\r\nBuzz\r\nFizz\r\n127\r\n128\r\nFizz\r\nBuzz\r\n131\r\nFizz\r\n133\r\n134\r\nFizzBuzz\r\n136\r\n137\r\nFizz\r\n139\r\nBuzz\r\nFizz\r\n142\r\n143\r\nFizz\r\nBuzz\r\n146\r\nFizz\r\n148\r\n149\r\nFizzBuzz\r\n";

            List<string> tokens = new() { "Fizz", "Buzz" };

            List<int> divisors = new() { 3, 5 };

            Assert.AreEqual(TwistedFizzBuzz.FizzBuzz.GeneralUsage(150, -150, divisors, tokens), assertString);
        }

        [TestMethod]
        public void GeneralUsageFizzBuzzWrongImputAmount()
        {
            List<string> tokens = new() { "Fizz", "Buzz","Bar" };

            List<int> divisors = new() { 3, 5 };

            Assert.ThrowsException<ArgumentException>(() => TwistedFizzBuzz.FizzBuzz.GeneralUsage(150, -150, divisors, tokens), "There has to be the same number of divisors and tokens.");
        }

        [TestMethod]
        public void RichFizzBuzz()
        {
            TwistedFizzBuzz.RichResponse assertionResponce = new() { Multiple = 25, Word = "indication" };

            string assertString = "indication\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12\r\n13\r\n14\r\n15\r\n16\r\n17\r\n18\r\n19\r\n20\r\n21\r\n22\r\n23\r\n24\r\nindication\r\n26\r\n27\r\n28\r\n29\r\n30\r\n31\r\n32\r\n33\r\n34\r\n35\r\n36\r\n37\r\n38\r\n39\r\n40\r\n41\r\n42\r\n43\r\n44\r\n45\r\n46\r\n47\r\n48\r\n49\r\nindication\r\n51\r\n52\r\n53\r\n54\r\n55\r\n56\r\n57\r\n58\r\n59\r\n60\r\n61\r\n62\r\n63\r\n64\r\n65\r\n66\r\n67\r\n68\r\n69\r\n70\r\n71\r\n72\r\n73\r\n74\r\nindication\r\n76\r\n77\r\n78\r\n79\r\n80\r\n81\r\n82\r\n83\r\n84\r\n85\r\n86\r\n87\r\n88\r\n89\r\n90\r\n91\r\n92\r\n93\r\n94\r\n95\r\n96\r\n97\r\n98\r\n99\r\nindication\r\n";
            
            Assert.AreEqual(TwistedFizzBuzz.FizzBuzz.RichRed(assertionResponce), assertString);
        }

        [TestMethod]
        public void NonSequentialFizzBuzz()
        {
            string assertString = "Fizz\r\nBuzz\r\n8\r\nBuzz\r\n";

            List<int> numbers = new() { 3,5,8,10 };

            List<int> divisors = new() { 3, 5 };

            List<string> tokens = new() { "Fizz", "Buzz" };

            Assert.AreEqual(TwistedFizzBuzz.FizzBuzz.NonSequential(numbers,divisors,tokens), assertString);
        }

        [TestMethod]
        public void NonSequentialFizzBuzzWrongImputAmount()
        {
            List<int> numbers = new() { 3, 5, 8, 10 };

            List<int> divisors = new() { 3, 5 };

            List<string> tokens = new() { "Fizz", "Buzz", "Bar" };

            Assert.ThrowsException<ArgumentException>(() => TwistedFizzBuzz.FizzBuzz.GeneralUsage(150, -150, divisors, tokens), "There has to be the same number of divisors and tokens.");
        }


    }
}