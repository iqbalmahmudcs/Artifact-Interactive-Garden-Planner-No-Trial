using Task4;

Cannon defaultCannon = new Cannon();
defaultCannon.TakePhoto(1080, 720);
defaultCannon.RecordVideo(50);

Cannon modelCannon = new Cannon("EOS 90D");
modelCannon.TakePhoto(4243, 2323);
modelCannon.RecordVideo(60);

Cannon customCannon = new Cannon("EOS R6", "Gray");
customCannon.TakePhoto(1221, 2332);
customCannon.RecordVideo(30);