// Nested HTML using React
// For sibling elements, use array
const nestedStruct = React.createElement("div", {id: "parent"}, 
    [
        React.createElement("div", {id: "child"}, 
        [
            React.createElement("h1", {}, "Heading 1"), 
            React.createElement("h2", {}, "Heading 2")
        ]),
        React.createElement("div", {id: "child1"}, 
            [
                React.createElement("h1", {}, "Heading 1"), 
                React.createElement("h2", {}, "Heading 2")
            ])
        ]
);

const root1 = ReactDOM.createRoot(document.getElementById("root1"));
root1.render(nestedStruct);