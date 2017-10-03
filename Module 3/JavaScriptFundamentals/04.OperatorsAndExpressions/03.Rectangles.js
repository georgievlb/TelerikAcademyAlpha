function AreaAndParameter(array){
	let width = (array[0]);
	let height = (array[1]);
	let area = (width * height);
	let parameter = (2 * width) + (2 * height);
  return (area.toFixed(2) + " " + parseFloat(parameter).toFixed(2));
}