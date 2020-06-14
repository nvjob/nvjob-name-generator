// Copyright (c) 2016 Unity Technologies. MIT license - license_unity.txt
// #NVJOB Name Generator. MIT license - license_nvjob.txt
// #NVJOB Name Generator v1.1 - https://nvjob.github.io/unity/nvjob-name-generator
// #NVJOB Nicholas Veselov - https://nvjob.github.io
// #NVJOB Store - https://nvjob.github.io/store/


using UnityEngine;


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


public static class NVJOBNameGen
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public static string GiveAName(int type)
    {
        //--------------

        string nameFinal = "";
        string[] firstName = new string[] { };

        //--------------

        if (type > 0)
        {
            if (type <= 4)  //  Normal English Names ---------------------------
            {
                if (type == 1)  //  Female Old Name (321)
                {
                    firstName = new string[] { "Alicia", "Amanda", "Amy", "Angela", "Anna", "Anne", "Annie", "April", "Audrey", "Barbara", "Becky", "Belinda",
                        "Beth", "Betty", "Bonnie", "Brenda", "Carla", "Carmen", "Carole", "Carolyn", "Catherine", "Charlene", "Charlotte", "Christina",
                        "Christine", "Cindy", "Claudia", "Colleen", "Constance", "Crystal", "Cynthia", "Dana", "Darlene", "Dawn", "Deanna", "Debbie",
                        "Deborah", "Debra", "Delores", "Denise", "Diana", "Diane", "Dianne", "Dolores", "Donna", "Doreen", "Doris", "Dorothy", "Eileen",
                        "Elaine", "Elizabeth", "Ellen", "Eva", "Evelyn", "Felicia", "Frances", "Gail", "Gayle", "Geraldine", "Gina", "Glenda", "Gloria",
                        "Grace", "Gwendolyn", "Heather", "Heidi", "Helen", "Holly", "Irene", "Jackie", "Jacqueline", "Jamie", "Jan", "Jane", "Janet",
                        "Janice", "Janis", "Jean", "Jeanette", "Jeanne", "Jennifer", "Jill", "Jo", "Joan", "Joann", "Joanne", "Jodi", "Jody", "Josephine",
                        "Joy", "Joyce", "Juanita", "Judith", "Judy", "Julia", "Julie", "June", "Karen", "Karla", "Katherine", "Kathleen", "Kathryn", "Kathy",
                        "Kay", "Kelly", "Kim", "Kimberly", "Kristen", "Kristin", "Kristine", "Laura", "Laurie", "Leslie", "Lillian", "Linda", "Lisa", "Lois",
                        "Loretta", "Lori", "Lorraine", "Louise", "Lynda", "Lynn", "Lynne", "Marcia", "Margaret", "Maria", "Marianne", "Marie", "Marilyn",
                        "Marjorie", "Marlene", "Marsha", "Martha", "Mary", "Maureen", "Melanie", "Melinda", "Melissa", "Melody", "Michele", "Michelle", "Mildred",
                        "Monica", "Nancy", "Natalie", "Nicole", "Norma", "Pam", "Pamela", "Patricia", "Patsy", "Patti", "Patty", "Paula", "Peggy", "Penny",
                        "Phyllis", "Rachel", "Rebecca", "Regina", "Renee", "Rhonda", "Rita", "Roberta", "Robin", "Rosa", "Rose", "Rosemary", "Roxanne", "Ruby",
                        "Ruth", "Sally", "Sandra", "Sandy", "Sara", "Sarah", "Shannon", "Shari", "Sharon", "Sheila", "Shelia", "Shelley", "Shelly", "Sheri",
                        "Sherri", "Sherry", "Sheryl", "Shirley", "Sonya", "Stacey", "Stacy", "Stephanie", "Sue", "Susan", "Suzanne", "Sylvia", "Tamara",
                        "Tami", "Tammie", "Tammy", "Tanya", "Teresa", "Terri", "Terry", "Theresa", "Tina", "Toni", "Tonya", "Tracey", "Traci", "Tracy",
                        "Valerie", "Vanessa", "Veronica", "Vicki", "Vickie", "Vicky", "Victoria", "Virginia", "Vivian", "Wanda", "Wendy", "Yolanda", "Yvette",
                        "Agnes", "Alberta", "Alice", "Alma", "Andrea", "Anita", "Ann", "Annette", "Arlene", "Beatrice", "Bernice", "Bertha", "Bessie", "Beverly",
                        "Billie", "Bobbie", "Carol", "Caroline", "Carrie", "Cathy", "Cheryl", "Claire", "Clara", "Connie", "Cora", "Daisy", "Dora", "Edith",
                        "Edna", "Eleanor", "Ella", "Elsie", "Emily", "Emma", "Erma", "Esther", "Ethel", "Eunice", "Fannie", "Faye", "Florence", "Geneva",
                        "Genevieve", "Georgia", "Gertrude", "Gladys", "Harriet", "Hattie", "Hazel", "Hilda", "Ida", "Janie", "Jeannette", "Jennie", "Jessie",
                        "Johnnie", "Lena", "Leona", "Lillie", "Lola", "Lucille", "Lucy", "Lula", "Mae", "Margie", "Marguerite", "Marian", "Marion", "Maryann",
                        "Mattie", "Maxine", "Minnie", "Myrna", "Myrtle", "Naomi", "Nellie", "Nina", "Pat", "Paulette", "Pauline", "Pearl", "Priscilla", "Ramona",
                        "Rosalie", "Rosemarie", "Rosie", "Stella", "Thelma", "Velma", "Vera", "Verna", "Viola", "Violet", "Willie", "Wilma", "Yvonne" };
                }
                else if (type == 2)  //  Female New Name (386)
                {
                    firstName = new string[] { "Aaliyah", "Abby", "Abigail", "Addison", "Adriana", "Adrianna", "Alana", "Alejandra", "Alexa", "Alexandra",
                        "Alexandria", "Alexia", "Alexis", "Alison", "Allison", "Alondra", "Alyssa", "Amanda", "Amber", "Amelia", "Amy", "Ana", "Andrea",
                        "Angel", "Angelica", "Angelina", "Ariana", "Arianna", "Ariel", "Ashlee", "Ashley", "Ashlyn", "Aubrey", "Audrey", "Autumn", "Ava",
                        "Avery", "Bailey", "Bethany", "Bianca", "Brandi", "Brandy", "Breanna", "Brenda", "Briana", "Brianna", "Brittany", "Brittney",
                        "Brooke", "Brooklyn", "Caitlin", "Caitlyn", "Camila", "Carly", "Caroline", "Casey", "Cassandra", "Cassidy", "Catherine", "Charlotte",
                        "Chelsea", "Chelsey", "Cheyenne", "Chloe", "Christina", "Cindy", "Claire", "Courtney", "Crystal", "Daisy", "Daniela", "Danielle",
                        "Deanna", "Delaney", "Desiree", "Destiny", "Diamond", "Diana", "Dominique", "Elizabeth", "Ella", "Ellie", "Emily", "Emma", "Erica",
                        "Erika", "Erin", "Eva", "Evelyn", "Faith", "Felicia", "Gabriela", "Gabriella", "Gabrielle", "Genesis", "Gianna", "Gina", "Giselle",
                        "Grace", "Gracie", "Hailey", "Haley", "Hannah", "Hayley", "Heather", "Holly", "Hope", "Isabel", "Isabella", "Isabelle", "Jacqueline",
                        "Jada", "Jade", "Jamie", "Jasmin", "Jasmine", "Jayla", "Jazmin", "Jenna", "Jennifer", "Jessica", "Jillian", "Joanna", "Jocelyn",
                        "Jordan", "Jordyn", "Julia", "Juliana", "Julie", "Kaitlin", "Kaitlyn", "Kara", "Karen", "Karina", "Kate", "Katelyn", "Katherine",
                        "Kathleen", "Kathryn", "Katie", "Katrina", "Kayla", "Kaylee", "Kelly", "Kelsey", "Kendall", "Kendra", "Kennedy", "Kiara", "Kimberly",
                        "Kirsten", "Krista", "Kristen", "Kristin", "Kristina", "Krystal", "Kylee", "Kylie", "Laura", "Lauren", "Layla", "Leah", "Leslie",
                        "Liliana", "Lillian", "Lilly", "Lily", "Lindsay", "Lindsey", "Lisa", "Lucy", "Lydia", "Mackenzie", "Madeline", "Madelyn", "Madison",
                        "Makayla", "Makenzie", "Mallory", "Margaret", "Maria", "Mariah", "Marisa", "Marissa", "Mary", "Maya", "Mckenzie", "Meagan", "Megan",
                        "Meghan", "Melanie", "Melissa", "Mercedes", "Mia", "Michaela", "Michelle", "Mikayla", "Miranda", "Molly", "Monica", "Monique", "Morgan",
                        "Mya", "Nancy", "Naomi", "Natalia", "Natalie", "Natasha", "Nevaeh", "Nicole", "Olivia", "Paige", "Patricia", "Payton", "Peyton",
                        "Rachael", "Rachel", "Raven", "Reagan", "Rebecca", "Rebekah", "Riley", "Ruby", "Rylee", "Sabrina", "Sadie", "Samantha", "Sandra",
                        "Sara", "Sarah", "Savannah", "Selena", "Serenity", "Shannon", "Shelby", "Sierra", "Skylar", "Sofia", "Sophia", "Sophie", "Stephanie",
                        "Summer", "Sydney", "Tara", "Taylor", "Tiffany", "Trinity", "Valeria", "Valerie", "Vanessa", "Veronica", "Victoria", "Whitney",
                        "Yesenia", "Zoe", "Zoey", "Adrienne", "Aimee", "Alicia", "Alisha", "Angela", "Angie", "Anita", "Ann", "Anna", "Anne", "Annette", "April",
                        "Barbara", "Becky", "Beth", "Bonnie", "Bridget", "Candace", "Candice", "Carla", "Carmen", "Carol", "Carolyn", "Carrie", "Cassie",
                        "Cathy", "Cheryl", "Christie", "Christine", "Christy", "Claudia", "Colleen", "Connie", "Cristina", "Cynthia", "Dana", "Dawn", "Deborah",
                        "Debra", "Denise", "Diane", "Donna", "Ebony", "Gloria", "Heidi", "Jaclyn", "Jaime", "Janet", "Janice", "Jeanette", "Jenny", "Jill",
                        "Jodi", "Jody", "Joy", "Kari", "Kathy", "Kelli", "Kellie", "Kerri", "Kerry", "Kim", "Kristi", "Kristie", "Kristine", "Kristy", "Lacey",
                        "Latasha", "Latoya", "Laurie", "Linda", "Lori", "Lynn", "Mandy", "Marie", "Martha", "Melinda", "Meredith", "Michele", "Mindy", "Misty",
                        "Nichole", "Nina", "Pamela", "Paula", "Priscilla", "Regina", "Renee", "Rhonda", "Robin", "Robyn", "Ruth", "Sharon", "Shawna", "Sheena",
                        "Sheila", "Shelley", "Shelly", "Sheri", "Sherri", "Sherry", "Sonia", "Sonya", "Stacey", "Stacie", "Stacy", "Stefanie", "Susan",
                        "Suzanne", "Tabitha", "Tamara", "Tammy", "Tanya", "Tasha", "Teresa", "Terri", "Theresa", "Tina", "Toni", "Tonya", "Tracey", "Traci",
                        "Tracie", "Tracy", "Tricia", "Virginia", "Wanda", "Wendy", "Yolanda", "Yvonne" };
                }
                else if (type == 3)  //  Male Old Name (280)
                {
                    firstName = new string[] { "Aaron", "Adam", "Alan", "Albert", "Alexander", "Alfred", "Allan", "Allen", "Alvin", "Andre", "Andrew", "Anthony",
                        "Antonio", "Arnold", "Arthur", "Barry", "Benjamin", "Bernard", "Bill", "Billy", "Bob", "Bobby", "Brad", "Bradley", "Brent", "Brett", "Brian",
                        "Bruce", "Bryan", "Calvin", "Carl", "Carlos", "Chad", "Charles", "Charlie", "Chris", "Christopher", "Clarence", "Clifford", "Clyde", "Craig",
                        "Curtis", "Dale", "Dan", "Dana", "Daniel", "Danny", "Darin", "Darrell", "Darren", "Darryl", "Daryl", "Dave", "David", "Dean", "Dennis", "Derek",
                        "Derrick", "Don", "Donald", "Donnie", "Douglas", "Duane", "Dwayne", "Dwight", "Earl", "Eddie", "Edward", "Edwin", "Eric", "Erik", "Ernest",
                        "Eugene", "Floyd", "Francis", "Frank", "Franklin", "Fred", "Freddie", "Frederick", "Garry", "Gary", "Gene", "George", "Gerald", "Gerard",
                        "Gilbert", "Glen", "Glenn", "Gordon", "Greg", "Gregg", "Gregory", "Guy", "Harold", "Harry", "Harvey", "Henry", "Herbert", "Herman",
                        "Howard", "Jack", "Jackie", "James", "Jason", "Jay", "Jeff", "Jeffery", "Jeffrey", "Jerome", "Jerry", "Jesse", "Jim", "Jimmie", "Jimmy",
                        "Joe", "Joel", "John", "Johnnie", "Johnny", "Jon", "Jonathan", "Jose", "Joseph", "Juan", "Karl", "Keith", "Kelly", "Kenneth", "Kent",
                        "Kerry", "Kevin", "Kim", "Kirk", "Kurt", "Kyle", "Lance", "Larry", "Lawrence", "Lee", "Leo", "Leon", "Leonard", "Leroy", "Leslie", "Lester",
                        "Lewis", "Lloyd", "Lonnie", "Louis", "Luis", "Lynn", "Manuel", "Marc", "Marcus", "Mark", "Martin", "Marvin", "Matthew", "Maurice", "Melvin",
                        "Michael", "Micheal", "Mike", "Milton", "Mitchell", "Nathan", "Neil", "Nicholas", "Norman", "Patrick", "Paul", "Perry", "Peter", "Philip",
                        "Phillip", "Ralph", "Randall", "Randolph", "Randy", "Ray", "Raymond", "Reginald", "Rex", "Richard", "Rick", "Rickey", "Ricky", "Robert",
                        "Robin", "Rodney", "Roger", "Ronald", "Ronnie", "Roy", "Russell", "Samuel", "Scott", "Sean", "Shane", "Shawn", "Stanley", "Stephen", "Steve",
                        "Steven", "Stuart", "Ted", "Terry", "Theodore", "Thomas", "Tim", "Timothy", "Todd", "Tom", "Tommy", "Tony", "Tracy", "Troy", "Tyrone",
                        "Vernon", "Victor", "Vincent", "Walter", "Warren", "Wayne", "Wesley", "William", "Willie", "Alex", "Alton", "Archie", "Ben", "Bennie",
                        "Benny", "Billie", "Carroll", "Cecil", "Chester", "Claude", "Clayton", "Clifton", "Clinton", "Delbert", "Dick", "Earnest", "Edgar",
                        "Elmer", "Everett", "Fredrick", "Homer", "Horace", "Hubert", "Hugh", "Jessie", "Junior", "Lowell", "Luther", "Lyle", "Marion", "Marshall",
                        "Max", "Morris", "Nathaniel", "Nelson", "Oliver", "Oscar", "Otis", "Roland", "Roosevelt", "Rudolph", "Salvatore", "Sam", "Sammy",
                        "Sidney", "Virgil", "Wallace", "Wendell", "Wilbur", "Willard", "Willis" };
                }
                else if (type == 4)  //  Male New Name (320)
                {
                    firstName = new string[] { "Aaron", "Abraham", "Adam", "Adrian", "Aidan", "Aiden", "Alan", "Alec", "Alejandro", "Alex", "Alexander", "Alexis",
                        "Allen", "Andre", "Andres", "Andrew", "Angel", "Anthony", "Antonio", "Ashton", "Austin", "Ayden", "Benjamin", "Blake", "Braden", "Bradley",
                        "Brady", "Brandon", "Brayden", "Brendan", "Brent", "Brett", "Brian", "Brody", "Bryan", "Bryce", "Bryson", "Caden", "Caleb", "Calvin",
                        "Cameron", "Carlos", "Carson", "Carter", "Casey", "Cesar", "Chad", "Charles", "Chase", "Christian", "Christopher", "Clayton", "Cody",
                        "Colby", "Cole", "Colin", "Collin", "Colton", "Conner", "Connor", "Cooper", "Corey", "Cory", "Craig", "Cristian", "Curtis", "Dakota",
                        "Dalton", "Damian", "Daniel", "Darius", "David", "Dennis", "Derek", "Derrick", "Devin", "Devon", "Diego", "Dillon", "Dominic", "Donald",
                        "Donovan", "Douglas", "Drew", "Dustin", "Dylan", "Edgar", "Eduardo", "Edward", "Edwin", "Eli", "Elias", "Elijah", "Emmanuel", "Eric",
                        "Erick", "Erik", "Ethan", "Evan", "Fernando", "Francisco", "Frank", "Gabriel", "Gage", "Garrett", "Gary", "Gavin", "George", "Giovanni",
                        "Grant", "Gregory", "Hayden", "Hector", "Henry", "Hunter", "Ian", "Isaac", "Isaiah", "Ivan", "Jack", "Jackson", "Jacob", "Jaden", "Jake",
                        "Jalen", "James", "Jared", "Jason", "Javier", "Jayden", "Jeffrey", "Jeremiah", "Jeremy", "Jerry", "Jesse", "Jesus", "Joel", "John",
                        "Johnathan", "Johnny", "Jonah", "Jonathan", "Jonathon", "Jordan", "Jorge", "Jose", "Joseph", "Joshua", "Josiah", "Juan", "Julian", "Justin",
                        "Kaden", "Kaleb", "Keith", "Kenneth", "Kevin", "Kyle", "Landon", "Larry", "Leonardo", "Levi", "Liam", "Logan", "Lucas", "Luis", "Luke",
                        "Malachi", "Malik", "Manuel", "Marco", "Marcus", "Mario", "Mark", "Martin", "Mason", "Mathew", "Matthew", "Max", "Maxwell", "Micah", "Michael",
                        "Miguel", "Mitchell", "Nathan", "Nathaniel", "Nicholas", "Nicolas", "Noah", "Nolan", "Oliver", "Omar", "Oscar", "Owen", "Parker", "Patrick",
                        "Paul", "Pedro", "Peter", "Peyton", "Philip", "Phillip", "Preston", "Randy", "Raymond", "Ricardo", "Richard", "Riley", "Robert", "Roberto",
                        "Ronald", "Ruben", "Ryan", "Samuel", "Scott", "Sean", "Sebastian", "Sergio", "Seth", "Shane", "Shawn", "Spencer", "Stephen", "Steven",
                        "Tanner", "Taylor", "Thomas", "Timothy", "Tony", "Travis", "Trenton", "Trevor", "Tristan", "Troy", "Tyler", "Victor", "Vincent", "Wesley",
                        "William", "Wyatt", "Xavier", "Zachary", "Albert", "Arthur", "Barry", "Billy", "Bobby", "Brad", "Bruce", "Carl", "Chris", "Clifford",
                        "Clinton", "Dale", "Damon", "Danny", "Darrell", "Darren", "Dean", "Duane", "Dwayne", "Eddie", "Ernest", "Eugene", "Frederick", "Geoffrey",
                        "Gerald", "Glenn", "Harold", "Harry", "Howard", "Jaime", "Jamie", "Jay", "Jeff", "Jeffery", "Jermaine", "Jerome", "Jimmy", "Joe", "Jon",
                        "Kelly", "Kristopher", "Kurt", "Lance", "Lawrence", "Lee", "Leonard", "Louis", "Marc", "Marvin", "Maurice", "Melvin", "Micheal", "Neil",
                        "Ralph", "Randall", "Reginald", "Ricky", "Rodney", "Roger", "Ronnie", "Ross", "Roy", "Russell", "Shannon", "Shaun", "Stanley", "Steve",
                        "Terrance", "Terrence", "Terry", "Theodore", "Todd", "Tommy", "Tracy", "Tyrone", "Walter", "Wayne", "Willie" };
                }
                //  Second Name (828)
                string[] secondName = new string[] { "Abbott", "Adams", "Adkins", "Aguirre", "Albert", "Alexander", "Alford", "Allen", "Allison", "Alston", "Anderson",
                    "Andrews", "Anthony", "Armstrong", "Arnold", "Ashley", "Atkins", "Atkinson", "Austin", "Avery", "Bailey", "Baird", "Baker", "Baldwin", "Ball",
                    "Ballard", "Banks", "Barber", "Barker", "Barlow", "Barnes", "Barnett", "Barr", "Barrera", "Barrett", "Barron", "Barry", "Bartlett", "Barton",
                    "Bass", "Bates", "Battle", "Bauer", "Baxter", "Beach", "Bean", "Beard", "Beasley", "Beck", "Becker", "Bell", "Bender", "Benjamin", "Bennett",
                    "Benson", "Bentley", "Benton", "Berg", "Berger", "Bernard", "Berry", "Best", "Bird", "Bishop", "Black", "Blackburn", "Blackwell", "Blair", "Blake",
                    "Blanchard", "Blankenship", "Blevins", "Bolton", "Bond", "Bonner", "Booker", "Boone", "Booth", "Bowen", "Bowers", "Bowman", "Boyd", "Boyer", "Boyle",
                    "Bradford", "Bradley", "Bradshaw", "Brady", "Branch", "Bray", "Brennan", "Brewer", "Bridges", "Briggs", "Bright", "Britt", "Brock", "Brooks",
                    "Brown", "Browning", "Bruce", "Bryan", "Bryant", "Buck", "Buckley", "Buckner", "Bullock", "Burch", "Burgess", "Burke", "Burks", "Burnett", "Burns",
                    "Burris", "Burt", "Burton", "Bush", "Butler", "Byers", "Byrd", "Cain", "Calderon", "Caldwell", "Callahan", "Cameron", "Campbell", "Cannon", "Carey",
                    "Carlson", "Carney", "Carpenter", "Carr", "Carson", "Carter", "Carver", "Case", "Casey", "Cash", "Chambers", "Chandler", "Chaney", "Chapman",
                    "Charles", "Chase", "Cherry", "Christensen", "Christian", "Church", "Clark", "Clarke", "Clay", "Clayton", "Clements", "Clemons", "Cleveland",
                    "Cline", "Cobb", "Coffey", "Cohen", "Cole", "Coleman", "Collier", "Collins", "Colon", "Combs", "Compton", "Conley", "Conner", "Conrad", "Conway",
                    "Cook", "Cooke", "Cooley", "Cooper", "Copeland", "Cotton", "Cox", "Craft", "Craig", "Crane", "Crawford", "Crosby", "Cross", "Cummings", "Cunningham",
                    "Curry", "Curtis", "Dale", "Dalton", "Daniel", "Daniels", "Daugherty", "Davenport", "David", "Davidson", "Davis", "Dawson", "Day", "Dean", "Decker",
                    "Dickerson", "Dickson", "Dillard", "Dillon", "Dixon", "Donaldson", "Donovan", "Dorsey", "Dotson", "Douglas", "Downs", "Doyle", "Drake", "Dudley",
                    "Duffy", "Duke", "Duncan", "Dunn", "Duran", "Durham", "Dyer", "Eaton", "Edwards", "Elliott", "Ellis", "Ellison", "Emerson", "England",
                    "English", "Erickson", "Evans", "Everett", "Ewing", "Farley", "Farmer", "Farrell", "Faulkner", "Ferguson", "Ferrell", "Fields", "Finch",
                    "Finley", "Fischer", "Fisher", "Fleming", "Fletcher", "Flores", "Flowers", "Floyd", "Flynn", "Foley", "Forbes", "Ford", "Foreman", "Foster",
                    "Fowler", "Fox", "Francis", "Franco", "Frank", "Franklin", "Franks", "Frazier", "Frederick", "Freeman", "French", "Frost", "Fry", "Frye",
                    "Fuller", "Fulton", "Gaines", "Gallagher", "Gallegos", "Galloway", "Gamble", "Gardner", "Garner", "Garrett", "Garrison", "Gates", "Gay", "Gentry",
                    "George", "Gibbs", "Gibson", "Gilbert", "Giles", "Gill", "Gilliam", "Gilmore", "Glass", "Glenn", "Glover", "Goff", "Golden", "Good",
                    "Goodman", "Goodwin", "Gordon", "Graham", "Grant", "Graves", "Gray", "Green", "Greene", "Greer", "Gregory", "Griffin", "Griffith", "Grimes",
                    "Gross", "Guy", "Hale", "Haley", "Hall", "Hamilton", "Hammond", "Hampton", "Hancock", "Haney", "Hansen", "Hanson", "Hardin", "Harding",
                    "Hardy", "Harmon", "Harper", "Harrell", "Harrington", "Harris", "Harrison", "Hart", "Hartman", "Harvey", "Hatfield", "Hawkins", "Hayden",
                    "Hayes", "Haynes", "Hays", "Head", "Heath", "Hebert", "Henderson", "Hendricks", "Hendrix", "Henry", "Hensley", "Henson", "Herman", "Herring",
                    "Hess", "Hester", "Hewitt", "Hickman", "Hicks", "Higgins", "Hill", "Hines", "Hinton", "Hobbs", "Hodge", "Hodges", "Hoffman", "Hogan",
                    "Holcomb", "Holden", "Holder", "Holland", "Holloway", "Holman", "Holmes", "Holt", "Hood", "Hooper", "Hoover", "Hopkins", "Hopper", "Horn",
                    "Horne", "Horton", "House", "Houston", "Howard", "Howe", "Howell", "Hubbard", "Huber", "Hudson", "Huff", "Huffman", "Hughes", "Hull", "Humphrey",
                    "Hunt", "Hunter", "Hurley", "Hurst", "Hutchinson", "Hyde", "Irwin", "Jackson", "Jacobs", "Jacobson", "James", "Jarvis", "Jefferson",
                    "Jenkins", "Jennings", "Jensen", "Johns", "Johnson", "Johnston", "Jones", "Jordan", "Joseph", "Joyce", "Justice", "Kane", "Keith", "Keller",
                    "Kelley", "Kelly", "Kennedy", "Kent", "Key", "Kidd", "King", "Kirby", "Kirk", "Kirkland", "Knight", "Knowles", "Knox", "Koch", "Kramer",
                    "Lamb", "Lambert", "Lancaster", "Landry", "Lane", "Lang", "Langley", "Lara", "Larsen", "Larson", "Lawrence", "Lawson", "Leon", "Leonard",
                    "Lester", "Levine", "Levy", "Lewis", "Lindsay", "Lindsey", "Little", "Livingston", "Lloyd", "Logan", "Long", "Lopez", "Lott", "Love", "Lowe",
                    "Lowery", "Lucas", "Luna", "Lynch", "Lynn", "Lyons", "Macdonald", "Mack", "Madden", "Maddox", "Maldonado", "Malone", "Mann", "Manning", "Marks",
                    "Marsh", "Marshall", "Martin", "Mason", "Massey", "Mathews", "Mathis", "Matthews", "Maxwell", "May", "Mayer", "Maynard", "Mays", "McBride",
                    "McCall", "McCarthy", "McCarty", "McClain", "McClure", "McConnell", "McCormick", "McCoy", "McCray", "McCullough", "McDaniel", "McDonald",
                    "McDowell", "McFadden", "McFarland", "McGee", "McGowan", "McGuire", "McIntosh", "McIntyre", "McKay", "McKee", "McKenzie", "McKinney",
                    "McKnight", "McLaughlin", "McLean", "McLeod", "McMahon", "McMillan", "McNeil", "McPherson", "Meadows", "Medina", "Melton", "Mercer",
                    "Merrill", "Merritt", "Meyer", "Meyers", "Michael", "Middleton", "Miles", "Miller", "Mills", "Miranda", "Mitchell", "Monroe", "Montgomery",
                    "Moody", "Moon", "Mooney", "Moore", "Moran", "Morgan", "Morin", "Morris", "Morrison", "Morrow", "Morse", "Morton", "Moses", "Mosley", "Moss",
                    "Mueller", "Mullen", "Mullins", "Murphy", "Murray", "Myers", "Nash", "Navarro", "Neal", "Nelson", "Newman", "Newton", "Nichols", "Nicholson",
                    "Nielsen", "Nixon", "Noble", "Noel", "Nolan", "Norman", "Norris", "Norton", "O'Brien", "O'Connor", "O'Donnell", "O'Neal", "O'Neil", "O'Neill",
                    "Oliver", "Olsen", "Olson", "Ortega", "Ortiz", "Osborn", "Osborne", "Owen", "Owens", "Pace", "Page", "Palmer", "Park", "Parker", "Parks",
                    "Parrish", "Parsons", "Patrick", "Patterson", "Patton", "Paul", "Payne", "Pearson", "Peck", "Pena", "Pennington", "Perkins", "Perry", "Peters",
                    "Petersen", "Peterson", "Phelps", "Phillips", "Pickett", "Pierce", "Pittman", "Pitts", "Pollard", "Poole", "Pope", "Porter", "Potter", "Potts",
                    "Powell", "Powers", "Pratt", "Preston", "Price", "Prince", "Puckett", "Quinn", "Ramsey", "Randall", "Randolph", "Ray", "Raymond", "Reed", "Reese",
                    "Reeves", "Reid", "Reilly", "Reyes", "Reynolds", "Rhodes", "Rich", "Richard", "Richards", "Richardson", "Richmond", "Riddle", "Riggs", "Riley",
                    "Rivera", "Rivers", "Roach", "Robbins", "Roberson", "Roberts", "Robertson", "Robinson", "Robles", "Rodgers", "Rogers", "Rollins", "Rose", "Ross",
                    "Roth", "Rowe", "Rowland", "Roy", "Rush", "Russell", "Ryan", "Sampson", "Sanders", "Sanford", "Sargent", "Saunders", "Savage", "Sawyer",
                    "Scott", "Sears", "Sellers", "Serrano", "Sexton", "Shaffer", "Shannon", "Sharp", "Sharpe", "Shaw", "Shelton", "Shepard", "Shepherd",
                    "Sheppard", "Sherman", "Shields", "Short", "Simmons", "Simon", "Simpson", "Sims", "Singleton", "Skinner", "Slater", "Sloan", "Small", "Smith",
                    "Snider", "Snow", "Snyder", "Sparks", "Spears", "Spence", "Spencer", "Stafford", "Stanley", "Stanton", "Stark", "Steele", "Stein", "Stephens",
                    "Stephenson", "Stevens", "Stevenson", "Stewart", "Stokes", "Stone", "Stout", "Strickland", "Strong", "Stuart", "Sullivan", "Summers", "Sutton",
                    "Swanson", "Sweeney", "Sweet", "Sykes", "Talley", "Tanner", "Tate", "Taylor", "Terrell", "Terry", "Thomas", "Thompson", "Thornton", "Tillman",
                    "Todd", "Townsend", "Travis", "Tucker", "Turner", "Tyler", "Tyson", "Underwood", "Vaughan", "Vaughn", "Vincent", "Vinson", "Wade", "Wagner",
                    "Walker", "Wall", "Wallace", "Waller", "Walls", "Walsh", "Walter", "Walters", "Walton", "Ward", "Ware", "Warner", "Warren", "Washington",
                    "Waters", "Watkins", "Watson", "Watts", "Weaver", "Webb", "Weber", "Webster", "Weeks", "Wells", "West", "Wheeler", "Whitaker", "White",
                    "Whitehead", "Whitfield", "Whitley", "Whitney", "Wiggins", "Wilcox", "Wilder", "Wiley", "Wilkerson", "Wilkins", "Wilkinson", "William", "Williams",
                    "Williamson", "Willis", "Wilson", "Winters", "Wise", "Witt", "Wolf", "Wolfe", "Wood", "Woodard", "Woods", "Woodward", "Workman", "Wright",
                    "Wyatt", "Yates", "York", "Young" };
                nameFinal = firstName[Random.Range(0, firstName.Length)] + " " + secondName[Random.Range(0, secondName.Length)];
            }
            else if (type == 5 || type == 6)  //  Fantasy Names ---------------------------
            {
                if (type == 5)  //  Female Fantasy Name (534)
                {
                    firstName = new string[] { "Aerilaya", "Aelrie", "Aelua", "Aelynthi", "Aenwyn", "Aerith", "Ahrendue", "Ahshala", "Aila", "Alagossa",
                        "Alais", "Alanis", "Alasse", "Alavara", "Alea", "Aleesia", "Alenia", "Aleratha", "Allannia", "Allisa", "Alloralla", "Allynna",
                        "Almedha", "Almithara", "Alvaerelle", "Alyndra", "Amara", "Amaranthae", "Amarille", "Amedee", "Ameria", "Amisra", "Amnestria",
                        "Amra", "Anarzee", "Aneirin", "Anhaern", "Annallee", "Ara", "Arasne", "Aravae", "Arcaena", "Ariawyn", "Arilemna", "Arlayna",
                        "Arnarra", "Arryn", "Arthion", "Artin", "Ashera", "Ashryn", "Aurae", "Ava", "Axilya", "Ayda", "Ayla", "Azariah", "Baerinda",
                        "Bellaluna", "Bemere", "Bonaluria", "Burolia", "Caeda", "Caerthynna", "Calarel", "Celaena", "Cellica", "Chaenath", "Chalia",
                        "Chalsarda", "Chamylla", "Chandrelle", "Chasianna", "Ciliren", "Ciradyl", "Cithrel", "Clanire", "Cremia", "Daethie", "Daratrine",
                        "Darshee", "Darunia", "Dasyra", "Delimira", "Delsanra", "Dessielle", "Deulara", "Dilya", "Dirue", "Ealirel", "Ecaeris", "Edea",
                        "Edraele", "Eirina", "Elanalue", "Elanil", "Elasha", "Elenaril", "Eletha", "Elincia", "Elisen", "Eliyen", "Ellarian", "Elmyra",
                        "Eloimaya", "Elora", "Elyon", "Ena", "Enania", "Eshenesra", "Esiyae", "Essaerae", "Esta", "Falenas", "Faraine", "Farryn", "Faunalyn",
                        "Fayeth", "Faylen", "Fhaertala", "Filaurel", "Filauria", "Fildarae", "Finnea", "Gaelira", "Gaerradh", "Gaylia", "Geminara",
                        "Ghilanna", "Glynnii", "Gweyir", "Gwynnestri", "Gylledhia", "Haciathra", "Haera", "Halaema", "Halanaestra", "Hamalitia", "Haramara",
                        "Helartha", "Holone", "Huethea", "Hycis", "Ialantha", "Ikeshia", "Ildilyntra", "Ilmadia", "Ilsevel", "Ilyana", "Ilyrana", "Ilythyrra",
                        "Imizael", "Immianthe", "Imra", "Imryll", "Ioelena", "Irhaal", "Isarrel", "Isilynor", "Ithronel", "Itireae", "Itylara", "Jastira",
                        "Jeardra", "Jhaerithe", "Jhanandra", "Jhilsara", "Kali", "Kasula", "Kavrala", "Kaylessa", "Kaylin", "Keenor", "Keerla", "Keishara",
                        "Kenia", "Kethryllia", "Keya", "Kilyn", "Kylantha", "Kythaela", "Laamtora", "Laerdya", "Lazziar", "Leena", "Leilatha", "Lenna",
                        "Lensa", "Lethhonel", "Lierin", "Liluth", "Lithoniel", "Lixiss", "Llamiryl", "Llorva", "Loreleia", "Lura", "Lusha", "Lusserina",
                        "Lyeecia", "Lyeneru", "Lymseia", "Lyndis", "Lyra", "Lyrei", "Lythienne", "Madris", "Maelyrra", "Maeralya", "Maescia", "Makaela",
                        "Malonne", "Malruthiia", "Mariona", "Mathienne", "Maylin", "Meira", "Melarue", "Meorise", "Merethyl", "Merialeth", "Meriel",
                        "Merlara", "Mhoryga", "Micaiah", "Minuvae", "Muelara", "Myantha", "Mylaela", "Mylaerla", "Myriani", "Myrrh", "Nabeora",
                        "Naesala", "Naevys", "Naexi", "Nakiasha", "Nalaea", "Nambra", "Namys", "Nanthaliene", "Neia", "Nephinae", "Nimeroni", "Nimue",
                        "Nithenoel", "Nithroel", "Nuala", "Nueleth", "Nuovis", "Nushala", "Nyana", "Nylathria", "Ochilysse", "Omylia", "Osonia", "Penelo",
                        "Phaerille", "Phelorna", "Phinara", "Phyrra", "Pyria", "Qamara", "Radelia", "Raenisa", "Rallientha", "Rania", "Ratha", "Rathiain",
                        "Renestrae", "Renna", "Rina", "Riniya", "Rophalin", "Rosanhi", "Rosaniya", "Roshia", "Rubarae", "Ryllae", "Saelihn", "Saida",
                        "Sakaala", "Salihn", "Sana", "Saphielle", "Saria", "Sariandi", "Sarya", "Seldanna", "Selphie", "Selussa", "Shael", "Shaerra",
                        "Shalaevar", "Shalana", "Shalendra", "Shalheira", "Shalia", "Shanaera", "Shandalar", "Shanyrria", "Shelara", "Shenarah", "Sillavana",
                        "Sionia", "Siora", "Siphanien", "Siraye", "Solana", "Soliana", "Sorisana", "Sumina", "Syllia", "Sylmare", "Symania", "Syndra", "Syvis",
                        "Taenya", "Talanashta", "Talindra", "Tanelia", "Tanila", "Tanulia", "Tarasynora", "Tehlarissa", "Tephysea", "Teriani", "Thaciona",
                        "Thalia", "Thaola", "Thasinia", "Thessalia", "Tialha", "Tinesi", "Tiriana", "Tisha", "Tsarra", "Tyrael", "Ulesse", "Umilythe", "Uneathen",
                        "Urricea", "Usamea", "Vaeri", "Valindra", "Vanya", "Vasati", "Velatha", "Verrona", "Vestele", "Vianola", "Viessa", "Wynather", "Yaereene",
                        "Yalanue", "Yathanae", "Ygannea", "Ynaselle", "Yralissa", "Yrathea", "Yrneha", "Ysildea", "Yumanea", "Yunaesa", "Zaleria", "Zentha",
                        "Zestari", "Zilyana", "Adorellan", "Adresin", "Aelrindel", "Aerendyl", "Aien", "Ailen", "Ailre", "Aimer", "Aire", "Aithlin", "Alaion",
                        "Alosrin", "Amrynn", "Anfalen", "Anlyth", "Arbane", "Ardreth", "Arel", "Aubron", "Avourel", "Ayen", "Aymer", "Ayre", "Aywin", "Bellas",
                        "Bialaer", "Cohnal", "Conall", "Cornaith", "Cyran", "Dain", "Ehlark", "Ehrendil", "Elaith", "Elandorr", "Elas", "Elauthin", "Eldaerenth",
                        "Eldrin", "Elen", "Elidyr", "Elion", "Ellisar", "Elluin", "Elnaril", "Elpharae", "Elred", "Emmyth", "Erendriel", "Eroan", "Estelar",
                        "Faelyn", "Falael", "Felaern", "Feno", "Filverel", "Folen", "Folre", "Fylson", "Gaeleath", "Gaelin", "Galan", "Goras", "Goren", "Haemir",
                        "Halamar", "Haldir", "Halueth", "Halueve", "Hamon", "Horith", "Iefyr", "Ilbryen", "Iliphar", "Ilphas", "Inchel", "Ivasaar", "Jandar",
                        "Jassin", "Jhaan", "Jorildyn", "Kailu", "Katar", "Kelvhan", "Kendel", "Keryth", "Kharis", "Khidell", "Khiiral", "Khyrmin", "Kindreth",
                        "Kymil", "Laeroth", "Larrel", "Lathlaeril", "Lethonel", "Lhoris", "Llewel", "Lorsan", "Lyari", "Lysanthir", "Maeral", "Maiele", "Malon",
                        "Merellien", "Merith", "Methild", "Mirthal", "Mnementh", "Myrdin", "Myriil", "Myrin", "Narbeth", "Nasir", "Navarre", "Nelaeryn",
                        "Neremyn", "Nesterin", "Nhamashal", "Nieven", "Nym", "Orym", "Paeral", "Paeris", "Pelleas", "Phraan", "Rennyn", "Rhalyf", "Riluaneth",
                        "Rolim", "Ruehnar", "Ruvaen", "Ruven", "Ruvyn", "Ryo", "Saelethil", "Saevel", "Saleh", "Sanev", "Selanar", "Sharian", "Sinaht",
                        "Sylvar", "Taenaran", "Taeral", "Tamnaeth", "Tanathil", "Tannatar", "Tannyll", "Tanyl", "Tanyth", "Taranth", "Tarathiel", "Thalanil",
                        "Thallan", "Vaeril", "Vamir", "Venali", "Virion", "Vulen", "Vulmar", "Vulmer", "Vulwin", "Wirenth", "Yesanith", "Zeno" };
                }
                else if (type == 6)  //  Male Fantasy Name (561)
                {
                    firstName = new string[] { "Adorellan", "Abarat", "Adamar", "Adresin", "Aelrindel", "Aerendyl", "Aeson", "Afamrail", "Agandaur",
                        "Agis", "Aias", "Aiduin", "Aien", "Ailas", "Ailduin", "Ailen", "Ailluin", "Ailmar", "Ailmer", "Ailmon", "Ailre", "Ailred",
                        "Ailuin", "Ailwin", "Aimar", "Aimer", "Aimon", "Airdan", "Aire", "Aired", "Aithlin", "Aiwin", "Akkar", "Alabyran", "Alaion",
                        "Alas", "Alen", "Alinar", "Alluin", "Almar", "Almer", "Almon", "Alok", "Alosrin", "Alre", "Alred", "Althidon", "Alwin",
                        "Amrynn", "Andrathath", "Anfalen", "Anlyth", "Aolis", "Aquilan", "Arathorn", "Arbane", "Arbelladon", "Ardreth", "Ardryll",
                        "Arel", "Arlen", "Arun", "Ascal", "Athtar", "Aubron", "Aumanas", "Aumrauth", "Avourel", "Ayas", "Ayduin", "Ayen", "Ayluin",
                        "Aymar", "Aymer", "Aymon", "Ayre", "Ayred", "Aywin", "Belanor", "Beldroth", "Bellas", "Beluar", "Biafyndar", "Bialaer",
                        "Braern", "Cailu", "Camus", "Castien", "Chathanglas", "Cohnal", "Conall", "Connak", "Cornaith", "Corym", "Cyran", "Dain",
                        "Dakath", "Dalyor", "Darcassan", "Darfin", "Darthoridan", "Darunia", "Deldrach", "Delmuth", "Delsaran", "Devdan", "Drannor",
                        "Druindar", "Durlan", "Durothil", "Dyffros", "Edwyrd", "Edyrm", "Ehlark", "Ehrendil", "Eilauver", "Elaith", "Elandorr",
                        "Elas", "Elashor", "Elauthin", "Eldaerenth", "Eldar", "Eldrin", "Elduin", "Elen", "Elephon", "Elidyr", "Elion", "Elkhazel",
                        "Ellisar", "Elluin", "Elmar", "Elmer", "Elmon", "Elnaril", "Elorshin", "Elpharae", "Elre", "Elred", "Eltaor", "Elwin",
                        "Elyon", "Emmyth", "Entrydal", "Erendriel", "Eriladar", "Erlan", "Erlareo", "Erlathan", "Eroan", "Erolith", "Estelar",
                        "Ethlando", "Ettrian", "Evindal", "Faelar", "Faelyn", "Faeranduil", "Falael", "Felaern", "Fenian", "Feno", "Feyrith",
                        "Fhaornik", "Filarion", "Filvendor", "Filverel", "Flardryn", "Flinar", "Folas", "Folduin", "Folen", "Folluin", "Folmar",
                        "Folmer", "Folmon", "Folre", "Folred", "Folwin", "Fylson", "Gaeleath", "Gaelin", "Galaeron", "Galan", "Galather",
                        "Ganamede", "Gantar", "Garrik", "Garynnon", "Giullis", "Glanduil", "Glarald", "Glorandal", "Goras", "Gorduin", "Goren",
                        "Gorluin", "Gormar", "Gormer", "Gormon", "Gorre", "Gorred", "Gorwin", "Grathgor", "Haemir", "Hagas", "Hagduin",
                        "Hagen", "Hagluin", "Hagmar", "Hagmer", "Hagre", "Hagred", "Hagwin", "Haladavar", "Halafarin", "Halamar", "Haldir",
                        "Halflar", "Halueth", "Halueve", "Hamon", "Haryk", "Hastios", "Hatharal", "Horith", "Hubys", "Iefyr", "Ievis", "Ilbryen",
                        "Ilimitar", "Iliphar", "Illianaro", "Illithor", "Illitran", "Ilphas", "Ilrune", "Ilthuryn", "Ilvisar", "Inchel", "Inialos",
                        "Intevar", "Iolas", "Iolrath", "Itham", "Ivaran", "Ivasaar", "Iymbryl", "Iyrandrar", "Jandar", "Jannalor", "Jaonos", "Jassin",
                        "Jhaan", "Jhaartael", "Jhaeros", "Jonik", "Jorildyn", "Kailu", "Katar", "Katyr", "Kellam", "Kelvhan", "Kendel", "Kerym",
                        "Keryth", "Kesefeon", "Kharis", "Khatar", "Khidell", "Khiiral", "Khilseith", "Khuumal", "Khyrmin", "Kieran", "Kiirion",
                        "Kindroth", "Kivessin", "Klaern", "Kolvar", "Kuskyn", "Kymil", "Kyrenic", "Kyrtaar", "Laeroth", "Lafarallin", "Laiex",
                        "Lamruil", "Larongar", "Larrel", "Lathai", "Lathlaeril", "Lhoris", "Lianthorn", "Llarm", "Llewel", "Lorsan", "Luirlan",
                        "Luthais", "Luvon", "Lyari", "Lyklor", "Lysanthir", "Maeral", "Maiele", "Malgath", "Malon", "Maradeim", "Marikoth", "Marlevaur",
                        "Melandrach", "Merellien", "Merith", "Methild", "Mhaenal", "Mitalar", "Mihangyl", "Miirphys", "Mirthal", "Mlartlar", "Mnementh",
                        "Morthil", "Myrdin", "Myriil", "Myrin", "Mythanar", "Naertho", "Naeryndam", "Naesala", "Narbeth", "Nardual", "Nasir", "Navarre",
                        "Nelaeryn", "Neldor", "Neremyn", "Nesterin", "Nevarth", "Nhamashal", "Nieven", "Nindrol", "Ninleyn", "Ninthalor", "Niossae",
                        "Nuvian", "Nylian", "Nym", "Nyvorlas", "Olaurae", "Onas", "Oncith", "Onvyr", "Orist", "Ornthalas", "Orrian", "Orym", "Otaehryn",
                        "Othorion", "Paeral", "Paeris", "Pelleas", "Phaendar", "Pharom", "Phraan", "Pirphal", "Purtham", "Pyrravyn", "Pywaln", "Qildor",
                        "Raeran", "Raibyn", "Ralnor", "Ranaeril", "Rathal", "Reluraun", "Reluvethel", "Rennyn", "Reptar", "Respen", "Revalor", "Rhalyf",
                        "Rhangyl", "Rhistel", "Rhothomir", "Rhys", "Rilitar", "Riluaneth", "Rolim", "Rothilion", "Ruehnar", "Ruith", "Ruvaen", "Ruven",
                        "Ruvyn", "Rychell", "Rydel", "Ryfon", "Ryo", "Ryul", "Saelethil", "Saevel", "Saleh", "Samblar", "Sanev", "Scalanis", "Selanar",
                        "Sharian", "Shaundyl", "Shyrrik", "Sihnion", "Silvyr", "Simimar", "Sinaht", "Siveril", "Sontar", "Sudryal", "Sundamar", "Sylvar",
                        "Sythaeryn", "Taegen", "Taenaran", "Taeral", "Taerentym", "Taleasin", "Tamnaeth", "Tanithil", "Tannatar", "Tannivh", "Tannyll",
                        "Tanyl", "Tanyth", "Taranath", "Tarathiel", "Taredd", "Tarron", "Tasar", "Tassarion", "Tathaln", "Thalanil", "Thallan", "Theodas",
                        "Theodemar", "Theoden", "Theodluin", "Theodmer", "Theodmon", "Theodre", "Theodred", "Thuridan", "Tiarsus", "Tolith", "Tordynnar",
                        "Toross", "Traeliorn", "Travaran", "Triandal", "Ualiar", "Uevareth", "Uldreyin", "Urdusin", "Usunaar", "Uthorim", "Vaalyun",
                        "Vaeril", "Vamir", "Varitan", "Velethuil", "Venali", "Vesryn", "Vesstan", "Virion", "Volodar", "Voron", "Vuduin", "Vulas",
                        "Vulen", "Vulluin", "Vulmar", "Vulmer", "Vulmon", "Vulre", "Vulred", "Vulwin", "Wirenth", "Wistari", "Wyn", "Wyninn", "Wyrran",
                        "Yalathanil", "Yesanith", "Yhendorn", "Ylyndar", "Zaos", "Zelphar", "Zeno", "Zhoron", "Aenwyn", "Aerith", "Alais", "Alanis",
                        "Alasse", "Amra", "Aneirin", "Anhaern", "Ariawyn", "Arryn", "Arthion", "Artin", "Ashryn", "Axilya", "Azariah", "Bemere",
                        "Caeda", "Calarel", "Chaenath", "Ciliren", "Ciradyl", "Cithrel", "Elanil", "Elisen", "Falenas", "Farryn", "Filaurel", "Gaerradh",
                        "Gweyir", "Halaema", "Hycis", "Imizael", "Irhaal", "Isarrel", "Isilynor", "Ithronel", "Keenor", "Kilyn", "Kindreth", "Lazziar",
                        "Lethonel", "Lierin", "Malonne", "Meriel", "Micaiah", "Myrrh", "Naevys", "Namys", "Nithenoel", "Nueleth", "Nuovis", "Rathiain",
                        "Ryllae", "Saelihn", "Saida", "Shalaevar", "Shandalar", "Sylmare", "Syvis", "Tanathil", "Taranth", "Tyrael", "Uneathen", "Wynather" };
                }
                //  Second Name 0 (98)
                string[] secondName0 = new string[] { "Ad", "Al", "Ae", "An", "Ara", "Ana", "Am", "Bal", "Bei", "Bi", "Bry", "Cai", "Car", "Chae", "Cra",
                    "Dae", "Da", "Dor", "Eil", "El", "Ela", "En", "Er", "Fa", "Fae", "Far", "Fen", "Gen", "Gil", "Glyn", "Gre", "Hei", "Hele", "Her",
                    "Hola", "Ian", "Iar", "Ili", "Ina", "Jo", "Kea", "Kel", "Key", "Kris", "Leo", "Lia", "Lora", "Lu", "Mag", "Mia", "Mira", "Mor",
                    "Nae", "Neri", "Nor", "Ola", "Olo", "Oma", "Ori", "Pa", "Per", "Pet", "Phi", "Pres", "Qi", "Qin", "Qui", "Ralo", "Rava", "Rey",
                    "Ro", "Sar", "Sha", "Syl", "The", "Tor", "Tra", "Tris", "Ula", "Ume", "Uri", "Va", "Val", "Ven", "Vir", "Waes", "Wran", "Wyn",
                    "Wysa", "Xyr", "Xil", "Yel", "Yes", "Yin", "Ylla", "Zin", "Zum", "Zyl" };
                //  Second Name 1 (100)
                string[] secondName1 = new string[] { "beros", "bella", "balar", "banise", "can", "ceran", "cyne", "caryn", "dan", "di", "dithas", "dove",
                    "faren", "fiel", "fina", "fir", "geiros", "gella", "golor", "gwyn", "hana", "harice", "hice", "horn", "jeon", "jor", "jyre", "kalyn",
                    "kas", "kian", "krana", "lamin", "lana", "lar", "lee", "len", "leth", "lynn", "maer", "maris", "menor", "moira", "myar", "mys", "na",
                    "nala", "nan", "neiros", "nelis", "norin", "peiros", "petor", "phine", "phyra", "qen", "qirelle", "quinal", "ra", "ralei", "ran", "rel",
                    "ren", "ric", "rie", "rieth", "ris", "ro", "rona", "rora", "roris", "salor", "sandoral", "satra", "stina", "sys", "thana", "thyra",
                    "toris", "tris", "tumal", "valur", "varis", "ven", "vyre", "warin", "wenys", "wraek", "wynn", "xalim", "xidor", "xina", "xisys",
                    "yarus", "ydark", "ynore", "yra", "zana", "zeiros", "zorwyn", "zumin" };
                string secondName = secondName0[Random.Range(0, secondName0.Length)] + secondName1[Random.Range(0, secondName1.Length)];
                nameFinal = firstName[Random.Range(0, firstName.Length)] + " " + secondName;
            }
            else if (type == 7)  //  Sci Fi Names ---------------------------
            {
                string[] name1 = new string[] { "gh", "br", "c", "cr", "dr", "g", "gr", "kr", "k", "kh", "n", "q", "qh", "sc", "scr", "str", "st", "t",
                    "tr", "thr", "v", "vr", "x", "z", "", "", "", "", "" };
                string[] name2 = new string[] { "a", "e", "ae", "ao", "ai", "au", "uo", "a", "e", "i", "o", "u", "i", "o", "u", "a", "e", "i", "o", "u",
                    "a", "e", "i", "o", "u", "a", "e", "i", "o", "u", "a", "e", "i", "o", "u" };
                string[] name3 = new string[] { "cr", "cz", "dr", "gr", "c", "k", "n", "q", "t", "v", "x", "z", "c", "cc", "gn", "gm", "gv", "gz", "k",
                    "kk", "kn", "kr", "kt", "kv", "kz", "lg", "lk", "lq", "lx", "lz", "nc", "ndr", "nkr", "ngr", "nk", "nq", "nqr", "nz", "q", "qr",
                    "qn", "rc", "rg", "rk", "rkr", "rq", "rqr", "sc", "sq", "str", "t", "v", "vr", "x", "z", "q", "k", "rr", "r", "t", "tt", "vv",
                    "v", "x", "z", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                string[] name4 = new string[] { "a", "e", "i", "", "a", "e", "i", "o", "u", "o", "u", "a", "e", "i", "o", "u", "oi", "ie", "ai", "ei", "eo", "ui" };
                string[] name5 = new string[] { "ks", "l", "ls", "n", "d", "ds", "k", "ns", "ts", "x" };
                int r1 = Random.Range(0, name1.Length);
                int r2 = Random.Range(0, name2.Length);
                int r3 = Random.Range(0, name3.Length);
                int r4 = Random.Range(0, name4.Length);
                int r5 = Random.Range(0, name5.Length);
                while (name3[r3] == name1[r1] || name3[r3] == name5[r5]) r3 = Random.Range(0, name3.Length);
                if (name3[r3] == "") r4 = 0;
                else while (name4[r4] == "") r4 = Random.Range(0, name4.Length);
                nameFinal = name1[r1] + name2[r2] + name3[r3] + name4[r4] + name5[r5];
            }
            else
            {
                nameFinal = "Base will be updated";
            }
        }
        else nameFinal = "No Name";

        //--------------

        return nameFinal;

        //--------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public static string Uppercase(string u) // Get the first letter of the string in uppercase.
    {
        //--------------

        if (string.IsNullOrEmpty(u)) return string.Empty;
        return char.ToUpper(u[0]) + u.Substring(1);

        //--------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}