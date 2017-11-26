#pragma strict
var timer : float = 5.0;
function Update () {
	timer -= Time.deltaTime;

	if(timer <= 0)
	{
		Application.LoadLevel(1);
	}
}
