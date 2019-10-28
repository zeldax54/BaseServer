

var canvas = $('#myCanvas');
$('#iterationscontainer').hide();

var squaresize = 7;
var delaytime = 2000; //Seconds to delay search for animation purposses
var separation = squaresize + 5;
var canvasArea = canvas[0].width * canvas[0].height; //reduce one squere to let space to margin
canvasArea = canvasArea - squaresize * 2;
var squarenumber = canvasArea / Math.pow(squaresize, 2); 
console.log("prev squares: "+squarenumber);
var points = [];
var lastpos = 0;
var squarescontainer = [];
var pivothistory = [];
var text = new PointText({
	point: view.center,
	justification: 'center',
	fontSize: 20,
	fillColor: 'green'
});

var startx = 0;
var starty = 0;
var realsquares = 1;
while (squarenumber > 0) {

	var squarepoint = new Point(startx, starty);
	points.push(squarepoint);
	var rectSize = new Size(squaresize, squaresize);
	var rect = new Rectangle(squarepoint, rectSize);
	var path = new Path.Rectangle(rect);
	path.fillColor = '#00c0ef';
	path.name = realsquares;
	squarescontainer.push(path);
	startx = startx + separation;
	if (startx >= canvas[0].width - separation) {
		startx = 0;
		starty = starty + separation;		
	}
	if (starty >= canvas[0].height - separation)
		squarenumber = 0;
	if (squarenumber > 0)
		realsquares++;	
	squarenumber=squarenumber-1;
}
console.log("real squares fix: " + realsquares);
$('#msj').text('one element in a ' + realsquares + ' elements list. The ammount of elements is based in screen size.');


function onMouseMove(event) {
	project.activeLayer.selected = false;
	if (event.item) {
		$('#pointing').text('Poiting: ' + event.item.name);	

	} else {
		$('#pointing').text('');
	}

	
}



//path.selected = true;


$('#mybutton').click(function () {
	var toSearchNumber = $('#tosearch').val();	
	$('#notfound').hide();	
	if (!isNaN(toSearchNumber) && toSearchNumber !== '' && toSearchNumber !== undefined) {		
		pivothistory = [];
		for (var i = 0; i < squarescontainer.length; i++) {
			squarescontainer[i].fillColor = '#00c0ef';
			squarescontainer[i].rotate(0);
		}
		binarySearch(toSearchNumber, squarescontainer, parseInt(squarescontainer.length / 2), 0, pivothistory);					
	}
	else {
		console.log('NAN');		
	}	
});

var binarySearch = function (toSearch, squarescontainercopy, pivot,iteraciones,pivothistory) {

	var current = parseInt(squarescontainercopy[pivot].name);
	pivothistory.push(current);
	squarescontainercopy[pivot].fillColor = '#dd4b39';
	if (current === parseInt(toSearch)) {
		$('#iterationscontainer').show();
		$('#iterations').text(iteraciones);
		squarescontainercopy[pivot].fillColor = '#00a65a';
		return iteraciones;
	}
		
	if (pivot === 0 && current !== parseInt(toSearch)) {
		$('#iterationscontainer').hide();
		$('#iterations').hide();
		$('#notfound').show();

		return -1;
	}
		

	var subsquarecontainer = [];
	var disposecontainer = [];
	if (parseInt(toSearch) < current) {		
		subsquarecontainer = squarescontainercopy.slice(0, pivot);
		disposecontainer = squarescontainercopy.slice(pivot);
		pivot = parseInt(subsquarecontainer.length / 2);
	}
	else if (parseInt(toSearch) > current) {		
		subsquarecontainer = squarescontainercopy.slice(pivot);
		disposecontainer = squarescontainercopy.slice(0,pivot);
		pivot = parseInt(subsquarecontainer.length / 2);
	}
	
	console.log(pivothistory);
	for (var i = 0; i < disposecontainer.length; i++) {
		if (pivothistory.includes(parseInt(disposecontainer[i].name))===false)
			disposecontainer[i].fillColor = '#78208e';
		else
			disposecontainer[i].fillColor = '#dd4b39';
	}
	
	setTimeout(function () {		
		iteraciones = iteraciones + 1;
		return binarySearch(toSearch, subsquarecontainer, pivot, iteraciones, pivothistory);
	}, delaytime);
	
};

function onFrame(event) {	
	for (var i = 0; i < squarescontainer.length; i++) {
		if (pivothistory.includes(parseInt(squarescontainer[i].name)) === true) {			
			squarescontainer[i].rotate(3);
		}
	}	
}