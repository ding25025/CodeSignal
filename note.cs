int century = (int)Math.Ceiling((double)year / 100);
int years = (int)Math.Ceiling(Math.Log((double)threshold / deposit) / Math.Log(1 + rate / 100.0));