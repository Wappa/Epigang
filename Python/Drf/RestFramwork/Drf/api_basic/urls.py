from django.urls import path
from .views import ArticleListView, ArticleDetailView


urlpatterns = [
    path('article/',ArticleListView ),
    path('detail/<int:pk>',ArticleDetailView )
]
