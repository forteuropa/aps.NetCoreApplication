node {
	def application

		stage("Clone repository"){
			checkout scm
		}

 	
		stage('Building application'){
			bat "\"${tool 'MSBuild'}.msbuild.exe\" TemperatureApp.sln "
		}

	
}
