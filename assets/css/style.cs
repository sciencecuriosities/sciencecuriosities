/* 1. THE ESSENTIAL RESET */
/* This ensures padding doesn't "push" the width wider than the screen */
*, *::before, *::after {
  box-sizing: border-box;
}

html, body {
  margin: 0;
  padding: 0;
  width: 100%;
  /* This is the final safety net for horizontal scrolling */
  overflow-x: hidden; 
}

/* 2. HEADER & BANNER */
.site-header {
  width: 100%;
  position: relative;
  /* Removes any accidental gaps */
  display: flex;
  flex-direction: column;
}

.banner-image {
  width: 100%;
  max-width: 100%;
  height: auto;
  display: block;
}

/* 3. CONTENT SCALING */
/* This ensures your title and text stay inside the screen */
.title-pill, .site-nav, main, footer {
  width: 100%;
  max-width: 100%;
  padding: 0 20px; /* Gives your text some breathing room from the edges */
  text-align: center;
}

/* Make sure the title doesn't force a specific width */
h1 {
  word-wrap: break-word;
  font-size: 1.5rem; /* Adjusts size for mobile */
}

/* 4. NAVIGATION */
.site-nav a {
  display: inline-block;
  padding: 10px;
  text-decoration: none;
}
