// For inputString = "172.16.254.1", the output should be solution(inputString) = true;
// For inputString = "172.316.254.1", the output should be solution(inputString) = false.
// For inputString = ".254.255.0", the output should be solution(inputString) = false.
bool solution(string inputString)
{
    String[] ips = { };
    ips = inputString.Split(".");
    if (ips.Length != 4)
    {
        return false;
    }
    foreach (string ip in ips)
    {

        bool isNumerical = int.TryParse(ip, out int num);

        if (!isNumerical || !ip.All(char.IsDigit))
        {
            return false;
        }
        if (num < 0 || num > 255 || (ip.Length > 1 && ip[0] == '0'))
        {
            return false;
        }
    }
    return true;
}