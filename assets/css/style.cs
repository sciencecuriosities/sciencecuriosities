/* 1. Global Reset - Prevents padding from adding extra width */
*, *::before, *::after {
  box-sizing: border-box;
}

/* 2. Page Setup */
html, body {
  margin: 0;
  padding: 0;
  width: 100%;
  overflow-x: hidden; /* Prevents horizontal scrolling */
}

/* 3. Universal Image Rules - Makes all images responsive */
img {
  max-width: 100%; /* Image will never be wider than its container */
  height: auto;    /* Maintains aspect ratio */
  display: block;  /* Removes the tiny invisible gap under images */
}

/* 4. Banner Specifics */
.site-header {
  width: 100%;
  position: relative;
}

.banner-image {
  width: 100%;         /* Forces image to fill the screen width */
  object-fit: cover;   /* Ensures the image covers the area nicely */
}
