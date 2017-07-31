// cftoc.c : Defines the entry point for the console application.

#include "stdafx.h"
#include <time.h>

int function()
{
	double fahr, celsius;
	int lower, upper, step;

	lower = 0;
	upper = 1000000;
	step = 5;

	fahr = lower;
	while (fahr <= upper)
	{
		celsius = (5.0 / 9.0) * (fahr - 32.0);
		printf("%3.0f %6.1f\n", fahr, celsius);
		fahr = fahr + step;
	}
	return 0;
}

int main()
{
	clock_t start = clock(), diff;
	function();
	diff = clock() - start;

	int msec = diff * 1000 / CLOCKS_PER_SEC;
	printf("Time taken %d seconds %d milliseconds", msec / 1000, msec % 1000);
	getchar();
    return 0;
}

