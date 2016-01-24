var args = require('yargs')
	.default('configuration', 'Debug')
	.argv;
var path = require('path');

module.exports = function() {
    var config = {
		version: '04.01.00',
		company: 'DNNStuff',
		product: 'SQLViewPro',
		targets: [ 
            {target:'DNN7', framework:'v4.0'}, 
            {target:'DNN8', framework:'v4.5'}
            ],
		configurations: ['Release', 'Trial'],
        /**
         * File paths
        **/
		logPath: logPath,
		binPath: binPath,
		binSrc: binSrc,
		packagePath: packagePath,
        // solutions
		solutions: ['./*.sln'],
		// resources
		resources: [
			'./**/+(*.ascx|*.aspx)',
			'./**/App_LocalResources/*.resx',
			'./**/Reports/**/+(*.xml|*.js|*.xap|*.swf)',
			'./**/Skins/**',
			'./**/Repository/*.xml'
			],
		other: [
			'./Version/All/+(*.dnn|*.gif|*.gif|*.html)',			
			'./Version/Data/+(*.SqlDataProvider)'			
		]
    };

    return config;

};
var logPath = function() { return path.join(__dirname,'Build','logs');};
var binPath = function(target) { return path.join(__dirname,'Build','Output',target);};
var binSrc = function(target) { return binPath(target) + '/*.dll';};
var packagePath = function(target) { return path.join(__dirname,'Build',target,'package');};
