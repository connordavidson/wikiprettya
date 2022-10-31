import React, {
    Component 
}
from 'react'; 

import {
    Container, 
    Row, 
    Col, 
    Card ,
    ListGroup
}from 'react-bootstrap';


export class Page extends Component { 


    render(){ 
        document.title = 'Raleigh, North Carolina' + '- Wikiprettya';
        return( 
            <Container>
                <Row>

                    <Col xs={9}>

                        <h2>Raleigh, North Carolina</h2>
                        <hr/>
                        <small>info from Wikipedia</small>

                        <br/>
                        <br/>

                        <p>
                            Raleigh (/ˈrɑːli/; RAH-lee)[6] is the capital of the state of North Carolina and the seat of Wake County in the United States. 
                            It is the second-most populous city in North Carolina, after Charlotte, tenth-most populous city in the Southeast, 41st-most populous city in the U.S., and the largest city of the Research Triangle metro area. 
                            Raleigh is known as the "City of Oaks" for its many oak trees, which line the streets in the heart of the city.[7] 
                            The city covers a land area of 147.6 sq mi (382 km2). The U.S. Census Bureau counted the city's population as 474,069 in 2020.[8] 
                            It is one of the fastest-growing cities in the nation.[9][10] The city of Raleigh is named after Sir Walter Raleigh, who established the lost Roanoke Colony in present-day Dare County.
                        </p>
                        <p>
                            Raleigh is home to North Carolina State University (NC State) and is part of the Research Triangle together with Durham (home of Duke University and North Carolina Central University) and Chapel Hill (home of the University of North Carolina at Chapel Hill). 
                            The name of the Research Triangle (often shortened to the "Triangle") originated after the 1959 creation of Research Triangle Park (RTP), located in Durham and Wake counties, among the three cities and universities. 
                            The Triangle encompasses the U.S. Census Bureau's Raleigh-Durham-Cary Combined Statistical Area (CSA), which had an estimated population of 2,037,430 in 2013.[11] The Raleigh Metropolitan Statistical Area had an estimated population of 1,390,785 in 2019.[12]
                        </p>
                        <p>
                            Most of Raleigh is located within Wake County, with a very small portion extending into Durham County.[13] 
                            The towns of Cary, Morrisville, Garner, Clayton, Wake Forest, Apex, Holly Springs, Fuquay-Varina, Knightdale, Wendell, Zebulon, and Rolesville are some of Raleigh's primary nearby suburbs and satellite towns.
                        </p>
                        <p>
                            Raleigh is an early example in the United States of a planned city.[14] 
                            Following the American Revolutionary War when the U.S. gained independence, the area was chosen as the site of the state capital in 1788 and incorporated in 1792 as such. 
                            The city was originally laid out in a grid pattern with the North Carolina State Capitol in Union Square at the center. During the American Civil War, the city was spared from any significant battle. 
                            It fell to the Union in the closing days of the war, and struggled with the economic hardships in the postwar period, related to the reconstitution of labor markets, over-reliance on agriculture, and the social unrest of the Reconstruction Era. 
                            The establishment of the Research Triangle Park (RTP) in 1959, helped create tens of thousands of jobs in the fields of science and technology. By the early 21st century, Raleigh had become one of the fastest-growing cities in the United States.
                        </p>


                        <Card>
                            <Card.Header as="h5">Contents</Card.Header>
                            <Card.Body>
                                <Card.Text>
                                    <ol>
                                        <li>
                                            <a href="/page#history">History</a>
                                            <ol>
                                                <li>
                                                    <a href="/page#EarlierCapitals">Earlier capitals</a>
                                                </li>
                                                <li>
                                                    <a href="/page#18thCentury">Earlier capitals</a>
                                                </li>
                                            </ol>
                                        </li>
                                        <li>
                                            <a href="/page#geography">Geography</a>
                                            <ol>
                                                <li>
                                                    <a href="/page#InsideTheBeltline">Inside the Beltline</a>
                                                </li>
                                                <li>
                                                    <a href="/page#NorthRaleigh">North Raleigh</a>
                                                </li>
                                            </ol>
                                        </li>
                                    </ol>
                                </Card.Text>
                            </Card.Body>
                        </Card>

                        <br/>
                        <h5 id="history">History</h5>
                        <hr/>


                        <h6 id="EarlierCapitals">Earlier capitals<small>[edit]</small></h6>
                        <p>
                            Bath, the oldest town in North Carolina, was the first nominal capital of the colony from 1705 until 1722, when Edenton took over the role. 
                            The colony had no permanent institutions of government until the new capital, New Bern, was established in 1743.
                        </p>

                        <br/>

                        <h6 id="18thCentury">18th century<small>[edit]</small></h6>
                        <p>
                            In December 1770, Joel Lane successfully petitioned the North Carolina General Assembly to create a new county. On January 5, 1771, the bill creating Wake County was passed in the General Assembly.[15] 
                            The county was formed from portions of Cumberland, Orange, and Johnston counties, and was named for Margaret Wake Tryon, the wife of Governor William Tryon. The first county seat was Bloomsbury.
                        </p>
                        <p>
                            New Bern, a port town on the Neuse River 35 mi (56 km) from the Atlantic Ocean, was the largest city and the capital of North Carolina during the American Revolution. 
                            When the British Army laid siege to the city, that site could no longer be used as capital.[16] From 1789 to 1794, when Raleigh was being built, the state capital was Fayetteville.
                        </p>
                        <p>
                            Raleigh was chosen as the site of the new capital in 1788, as its central location protected it from attacks from the coast. 
                            It was officially established in 1792 as both county seat and state capital.[17] 
                            The city was incorporated on December 31, 1792, and a charter granted January 21, 1795.[citation needed] 
                            The city was named for Sir Walter Raleigh, sponsor of Roanoke, the "lost colony" on Roanoke Island.[18]
                        </p>


                        <br/>

                        <h5 id="geography">Geography</h5>
                        <hr/>

                        <p>
                            According to the United States Census Bureau, the city of Raleigh occupies a total area of 144.0 sq mi (373.0 km2), of which 142 sq mi (369 km2) is land and 0.97 sq mi (2.5 km2), or 0.76%, is covered by water. 
                            The Neuse River flows through the northeastern corner of the city.
                        </p>

                        <p>
                            The city of Raleigh is located 24 mi (39 km) southeast of Durham,[58] 63 mi (101 km) northeast of Fayetteville,[59] 131 mi (211 km) northwest of Wilmington,[60] 165 mi (266 km) northeast of Charlotte,[61] and 155 mi (249 km) southwest of Richmond, Virginia.[62] 
                            A small portion of Raleigh is located in Durham County, North Carolina.
                        </p>

                        <br/>
                        <h6 id="InsideTheBeltline">Inside the Beltline</h6>
                        
                        <p>
                            One common division of Raleigh is to differentiate the central part of the city, which lies inside of the circumferential highway known as the Raleigh Beltline (I-440 and I-40) from areas outside of the Beltline. 
                            The area inside of the beltline includes the entirety of the central business district known as Downtown Raleigh, as well as several more residential areas surrounding it.
                        </p>

                        <p>
                            The downtown area is home to historic buildings such as the Sir Walter Raleigh Hotel built in the early 20th century, the restored City Market, the Fayetteville Street downtown business district, which includes the PNC Plaza and Wells Fargo Capitol Center buildings, as well as the North Carolina Museum of History, North Carolina Museum of Natural Sciences, North Carolina State Capitol, William Peace University, the City of Raleigh Museum, Raleigh Convention Center, Shaw University, Campbell University School of Law, and St. Augustine's College.[64] 
                            In the 2000s, an effort by the Downtown Raleigh Alliance was made to separate this area of the city into five smaller districts: Fayetteville Street, Moore Square, Glenwood South, Warehouse (Raleigh), and Capital District (Raleigh).[65]
                        </p>

                        <br/>
                        <h6 id="NorthRaleigh">North Raleigh</h6>

                        <p> 
                            North Raleigh is an expansive, diverse, and fast-growing suburban area of the city that is home to established neighborhoods to the south along with many newly built subdivisions and along its northern fringes. 
                            The area generally falls North of Millbrook Road. 
                            It is primarily suburban with large shopping areas. Primary neighborhoods and subdivisions in North Raleigh include Bartons Creek Bluffs, Bedford, Bent Tree, Black Horse Run, Brier Creek, Brookhaven, Coachman's Trail, Crossgate, Crosswinds, Dominion Park, Durant Trails, Ethan's Glenn, Falls River, Greystone Village, Harrington Grove, Hidden Valley, Lake Park, Long Lake, North Haven, North Ridge, Oakcroft, Shannon Woods, Six Forks Station, Springdale Estates, Stonebridge, Stone Creek, Stonehenge, Summerfield, The Sanctuary, Valley Estates, Wakefield, Weathersfield, Windsor Forest, and Wood Valley. 
                            The area is served by a number of primary transportation corridors including Glenwood Avenue U.S. Route 70, Interstate 540, Wake Forest Road, Millbrook Road, Lynn Road, Six Forks Road, Spring Forest Road, Creedmoor Road, Leesville Road, Norwood Road, Strickland Road, and North Hills Drive.[75]
                        </p>

                    </Col> 
                    <Col xs={3}>
                        <br/>
                        <br/>
                        <br/>
                        <Card>
                            <Card.Body>
                                <Card.Title>
                                    Raleigh, North Carolina
                                </Card.Title>
                                <ListGroup variant="flush">
                                    <ListGroup.Item>Clockwise from top left: NC State bell tower, Confederate monument at the North Carolina State Capitol (now removed), houses in Boylan Heights, houses in Historic Oakwood, statue of Sir Walter Raleigh, skyline of the downtown, Fayetteville Street, and the warehouse district</ListGroup.Item>
                                    <ListGroup.Item>Nickname(s): City of Oaks, Raleigh Wood, Oak City</ListGroup.Item>
                                    <ListGroup.Item>
                                        <dl> 
                                            <dt>Country</dt>
                                            <dd>United States</dd>
                                            <dt>State</dt>
                                            <dd>North Carolina</dd>
                                            <dt>Counties</dt>
                                            <dd>Wake, Durham</dd>
                                        </dl>	 	
                                    </ListGroup.Item>
                                </ListGroup>
                                Right info pane

                            </Card.Body>

                        </Card>
                    </Col> 
                </Row>
            </Container>
        )
    }
}