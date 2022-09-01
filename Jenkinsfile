node {
	def application

		stage ('Clone repository'){
			checkout scm
		}
		
		stage('Restore Nuget'){
			bat 'C:\tools\nuget.exe restore TemperatureApp.sln'
		}

 	
		stage('Building application'){
			bat "\"${tool 'MSBuild'}msbuild.exe\" TemperatureApp.sln "
		}
		
		stage('Running Tests'){

		}

	
}
