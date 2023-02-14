
function Targeter(getvalues) {

	window.open(getvalues, '_blank');

}
function BackCrurrentPage(getvalues) {

	window.open(getvalues, '_blank');

}
function ready() {
	if (document.readyState == 'complete') {
		Webcam.set({
			width: 320,
			height: 240,
			image_format: 'jpeg',
			jpeg_quality: 90
		});
		try {
			Webcam.attach('#cameramer');
		} catch (e) {
			alert(e);
		}
	}
}

function take_snapshot() {
	// take snapshot and get image data
	var data = null;
	Webcam.snap(function (data_uri) {

		data = data_uri;
	});
	return data;
}

function stopVideo() {
	try {
		Webcam.reset('#cameramer');
	} catch (e) {
		alert(e);
	}

}





function downloadFile(mimeType, base64String, fileName) {

	var fileDataUrl = "data:" + mimeType + ";base64," + base64String;
	fetch(fileDataUrl)
		.then(response => response.blob())
		.then(blob => {

			//create a link
			var link = window.document.createElement("a");
			link.href = window.URL.createObjectURL(blob, { type: mimeType });
			link.download = fileName;

			//add, click and remove
			document.body.appendChild(link);
			link.click();
			document.body.removeChild(link);
		});

}
async function downloadFileFromStream(fileName, contentStreamReference) {
	const arrayBuffer = await contentStreamReference.arrayBuffer();
	const blob = new Blob([arrayBuffer]);
	const url = URL.createObjectURL(blob);
	triggerFileDownload(fileName, url);
	URL.revokeObjectURL(url);
}

function triggerFileDownload(fileName, url) {
	const anchorElement = document.createElement('a');
	anchorElement.href = url;

	if (fileName) {
		anchorElement.download = fileName;
	}

	anchorElement.click();
	anchorElement.remove();
}

