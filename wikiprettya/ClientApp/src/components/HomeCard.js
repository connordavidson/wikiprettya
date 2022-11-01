


import React, {Component} from 'react'; 
import { 
    Card, 
    CardBody, 
    CardTitle, 
    CardText , 
} from 'react-bootstrap' ; 


export class HomeCard extends Component{
     
    render(){
        
        return ( 
            <Card style={{marginBottom: 25 }}>
                <Card.Body>
                <Card.Title tag="h5">
                    {this.props.title}
                </Card.Title>
                <Card.Subtitle
                    className="mb-2 text-muted"
                    tag="h6"
                >
                    {this.props.subtitle}
                </Card.Subtitle>
                <Card.Link href={this.props.link_url}>
                    {this.props.link_text}
                </Card.Link>
                </Card.Body>
            </Card>
        )
    }
}
