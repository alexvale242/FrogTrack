export function getImageSize(imageElement, dotnetRef) {
    const aspectWidth = imageElement.naturalWidth;
    const aspectHeight = imageElement.naturalHeight;

    // If the image hasn't loaded yet add an event listener, else calculate immediately
    if (aspectWidth === undefined
        || aspectWidth === 0
        || aspectHeight === undefined
        || aspectHeight === 0) {
        imageElement.addEventListener("load", () => calculateAspectRatio(imageElement, dotnetRef));
    } else {
        calculateAspectRatio(imageElement, dotnetRef);
    }
}

export function calculateAspectRatio(imageElement, dotnetRef) {
    const aspectWidth = imageElement.naturalWidth;
    const aspectHeight = imageElement.naturalHeight;
    const aspectRatio = aspectWidth / aspectHeight;

    let aspect = "square";
    if (aspectRatio < 0.75) {
        aspect = "tall";
    } else if (aspectRatio > 1.6) {
        aspect = "wide";
    }
    
    dotnetRef.invokeMethodAsync('SetImageSize', aspect);
}