'use strict';

var Services = angular.module('Services', ['ngResource']);

Services.factory('PingRefresh', ['$resource',
  function ($resource) {
      return $resource('/api/PingRefresh/', {}, {
          query: { method: 'GET', isArray: false },
          save: { method: 'POST', isArray: false }
      });
  }]);

Services.factory('Environment', ['$resource',
  function ($resource) {
      return $resource('/api/Environment/', {}, {
          query: { method: 'GET', isArray: true }
      });
  }]);

Services.factory('Appli', ['$resource',
  function ($resource) {
      return $resource('/api/Appli/', {}, {
          query: { method: 'GET', isArray: true }
      });
  }]);

Services.factory('Dashboard', ['$resource',
  function ($resource) {
      return $resource('/api/Dashboard?environmentCode=:env&applicationCode=:app',
          { env: '@env', app: '@app' }, {
              query: { method: 'GET', isArray: true }
          });
  }]);

Services.factory('Monitor', ['$resource',
  function ($resource) {
      return $resource('/api/Monitor?pageIndex=:pageIndex&pageSize=:pageSize', 
          { pageIndex: '@pageIndex', pageSize: '@pageSize' }, {
              query: { method: 'GET', isArray: true }
          });
  }]);