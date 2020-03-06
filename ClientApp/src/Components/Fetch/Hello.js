import React from "react";
// import Header from "./Components/Header_Footer/Header";

class Hello extends React.Component {
  constructor(props) {
      super(props);
      this.state = {
          items: [],
          isLoaded: true,
      }
  }

  componentDidMount() {
    fetch('https://localhost:5001/People')
    .then(response => response.json())
    .then(json => console.log(json))

    //   fetch("https://localhost:5001/People", {
    //     method: "GET",
    // }).then(res => {
    //     //   res.json(); 
    //     console.log(res)
    // }).then(json => {
    //       this.setState({
    //           isLoaded : true, 
    //           items : json,
    //       })
    //   })
  }
  render() {
      var {isLoaded, items} = this.state;

         if(!isLoaded) {
          return <div>Loading.....</div>
         } else {
            return (
            <div className="APp">
             <ul>
                 {items.map(item=>(
                     <li key={item.id}>Name: item.name</li>
                 ))}
             </ul>
            
            
            </div>
            );
        }

    }

}

export default Hello;