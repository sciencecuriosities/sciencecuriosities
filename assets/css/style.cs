/* 1. THE ESSENTIAL RESET */
*, *::before, *::after {
  box-sizing: border-box;
}

html, body {
  margin: 0;
  padding: 0;
  width: 100%;
  overflow-x: hidden; /* Stops horizontal scrolling */
}

/* 2. BANNER - This ensures the image always fits the screen */
.banner-image {
  width: 100%;
  height: auto;       /* Keeps the image in proportion */
  display: block;
  max-width: 100%;
}

/* 3. TITLE PILL - Preventing the "Stretch" */
.title-pill {
  width: 100%;
  padding: 0 10px;    /* Keeps text from hitting the very edge */
  text-align: center;
}

h1 {
  margin: 10px 0;
  word-wrap: break-word; /* Allows long words to break if they have to */
  font-size: 2.5rem;     /* Desktop size */
}

/* 4. THE MOBILE FIX */
/* When the screen is 600px wide or less... */
@media (max-width: 600px) {
  h1 {
    font-size: 1.5rem;   /* Shrinks the title so it doesn't stretch the page */
  }
  
  .banner-image {
    /* Ensures the full width of the banner is visible on mobile */
    width: 100vw; 
    margin-left: 0;
    margin-right: 0;
  }
}

/* 5. NAV & MAIN */
.site-nav, main {
  width: 100%;
  max-width: 100%;
  padding: 20px;
  text-align: center;
}

.site-nav a {
  display: inline-block;
  padding: 10px;
  text-decoration: none;
}
