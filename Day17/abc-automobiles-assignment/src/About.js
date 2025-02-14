import React from 'react';
import './about.css';   // In About.js

class About extends React.Component {
    render() {
        return (
            <div className="container mt-4" data-testid="about-content">
                {/* Banner Image and About Us Content */}
                <div className="card mb-4">
                    {/* <img src="/path/to/banner.jpg" className="card-img-top" alt="About Us Banner" /> */}
                    <div className="card-body">
                        <h5 className="card-title">About Us</h5>
                        <p className="card-text">
                            Lorem ipsum is simply dummy text of the printing and typesetting industry.
                            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.
                        </p>
                    </div>
                </div>

                {/* Vehicle Cards Section */}
                <div className="row">
                    {/* Car 1 */}
                    <div className="col-md-4">
                        <div className="card">
                            <img src="/path/to/fronx.jpg" className="card-img-top" alt="Maruti Fronx" />
                            <div className="card-body">
                                <h5 className="card-title">Maruti Fronx</h5>
                                <p className="card-text">
                                    Maruti Fronx price starts at Rs. 8.99 Lakh and goes up to Rs. 16.16 Lakh.
                                </p>
                                <p className="text-muted">Last updated 3 mins ago</p>
                            </div>
                        </div>
                    </div>

                    {/* Car 2 */}
                    <div className="col-md-4">
                        <div className="card">
                            <img src="/path/to/creta.jpg" className="card-img-top" alt="Hyundai Creta N Line" />
                            <div className="card-body">
                                <h5 className="card-title">Hyundai Creta N Line</h5>
                                <p className="card-text">
                                    Price starts at Rs. 20.92 Lakh and goes up to Rs. 25.77 Lakh.
                                </p>
                                <p className="text-muted">Last updated 3 mins ago</p>
                            </div>
                        </div>
                    </div>

                    {/* Car 3 */}
                    <div className="col-md-4">
                        <div className="card">
                            <img src="/path/to/scorpio.jpg" className="card-img-top" alt="Mahindra Scorpio N" />
                            <div className="card-body">
                                <h5 className="card-title">Mahindra Scorpio N</h5>
                                <p className="card-text">
                                    Price starts at Rs. 17.13 Lakh and goes up to Rs. 31.08 Lakh.
                                </p>
                                <p className="text-muted">Last updated 3 mins ago</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default About;
