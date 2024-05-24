
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import AppContent from './components/AppContent';
import AppFooter from './components/AppFooter';
import AppHeader from './components/AppHeader';
import AppWeatherForecast from './components/AppWeatherForecast';


function App() {
  return (
    <div className="container-fluid">
      <div className='row'>
          <AppHeader/>
          <AppContent>
                  <div className='col-6'>
                      <div className='row'>
                        <div className='col-12 spot'>
                          <h3>WeatherForecast</h3>
                           <AppWeatherForecast/>
                        </div>                        
                      </div>
                      
                  </div>

                  <div className='col-6'>
                      <div className='row'>
                          <div className='col-12 spot'>
                            <h3>Products</h3>
                          </div>                          
                      </div>                      
                  </div>            
          </AppContent>
          <AppFooter/>
      </div>
    </div>
  );
}

export default App;
