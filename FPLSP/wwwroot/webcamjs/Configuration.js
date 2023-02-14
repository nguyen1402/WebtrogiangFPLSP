function ready_cabin() {
    if (document.readyState == 'complete') {
        Webcam.set({
            width: 480,
            height: 270,
            image_format: 'jpeg',
            jpeg_quality: 90
        });
        try {
            Webcam.attach('#camera-cabin');
        } catch (e) {
            alert(e);
        }
    }
}
function stop_cabin() {//tắt camera
    try {
        Webcam.reset('#camera-cabin');
    } catch (e) {
        alert(e);
    }
}

function take_snapshot_cabin() {
    // take snapshot and get image data
    var data = null;
    Webcam.snap(function (data_uri) {

        data = data_uri;
    });
    return data;
}
