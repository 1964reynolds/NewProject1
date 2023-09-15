using System;
namespace NewProject1
{
	public class Child
	{
		public class Child()
            

		{public string ChildchildName;

            public Child(string childchildName)
            {
                if (string.IsNullOrEmpty(childchildName))
                {
                    throw new ArgumentException($"'{nameof(childchildName)}' cannot be null or empty.", nameof(childchildName));
                }

                ChildchildName = childchildName;

            user input string = childchildname;
        }
        }
	}
}

