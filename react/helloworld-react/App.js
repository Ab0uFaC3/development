// creates the required element - using React core module
// 1st param => HTML tag, 2nd param => object to pass attributes to tag, 3rd param => Text to be displayed
// returns a React element (JS object)
// props object = id:heading, Hello World (children)
const heading = React.createElement("h1", {id: "heading"}, "Hello World");

// creates a root element where all the React code will be executed (in our case div tag with id root) - using ReactDOM module
const root = ReactDOM.createRoot(document.getElementById("root"));

// renders the heading data in root
// converts the React element (heading) into HTML syntax recognized by the browser and attach it inside the root
root.render(heading);