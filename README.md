# LeetCode Solutions in C#

## Overview
This repository contains my solutions to various coding problems from [LeetCode](https://leetcode.com/). Each solution is implemented in **C#**, with a focus on clarity, efficiency, and adherence to best coding practices.

## Repository Structure
The repository is organized as follows:

```
leetcode-solutions/
|-- Easy/
|   |-- ProblemName1.cs
|   |-- ProblemName2.cs
|
|-- Medium/
|   |-- ProblemName1.cs
|   |-- ProblemName2.cs
|
|-- Hard/
    |-- ProblemName1.cs
    |-- ProblemName2.cs

```
- **Easy/**: Solutions to problems classified as "Easy."
- **Medium/**: Solutions to problems classified as "Medium."
- **Hard/**: Solutions to problems classified as "Hard."

## File Naming Convention
Each file is named after the problem title from LeetCode, replacing spaces with camel case and removing special characters. For example:
- Problem: "Two Sum"
- File Name: `TwoSum.cs`

## How to Use
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/leetcode-solutions.git
   ```
2. Navigate to the desired problem's directory (`Easy`, `Medium`, or `Hard`).
3. Open the `.cs` file in your preferred IDE or text editor.

## Solution Format
Each solution file includes:
- A link to the original problem on LeetCode as a comment.
- The solution implemented as a C# method or class.

Example:
```csharp
// Problem: Two Sum
// Link: https://leetcode.com/problems/two-sum/
// Description: Given an array of integers nums and an integer target, 
// return indices of the two numbers such that they add up to target.

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        throw new ArgumentException("No solution found");
    }
}
```

## Contributing
Feel free to contribute by submitting pull requests or suggesting improvements! If you have better or alternative solutions, I would love to see them.

## License
This repository is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

---

Happy coding!
