for(int i=1;i<1=00;i++)
{
	let res="";
	switch(true)
	{
	case(i%3==0&&i%5==0)
		res+="fizzbuzz";
		break;
	case(i%3==0)
		res+="fizz";
		break;
	case(i%5==0)
		res+="buzz";
		break;
	default:
		res="i";
		break;
	}
	console.log(res);
}