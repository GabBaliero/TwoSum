using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[]? result = TwoSum(nums, target);
        if (result is { Length: 2 })
            Console.WriteLine($"Indices encontrados: {result[0]}, {result[1]}");
        else
            Console.WriteLine("Nenhuma solução encontrada.");
    }
    public static int[]? TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.TryGetValue(target - nums[i], out int j)) return [j, i];
            map[nums[i]] = i;
        }
        return null;
    }
}
